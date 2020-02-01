using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using Vacandum.Services.Abstractions;
using Vacandum.Services.Dto;
using Vacandum.Services.Models;

namespace Vacandum.Services.Services
{
	/// <summary>
	/// Vacancies service.
	/// </summary>
	public sealed class VacancyService : IVacancyService
	{
		private readonly IVacanciesRepository _vacanciesRepository;
		private readonly IHeadHunterClient _headHunterClient;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="vacanciesRepository">Vacancies repository.</param>
		/// <param name="headHunterClient">Client for Head Hunter Api.</param>
		public VacancyService(
			IVacanciesRepository vacanciesRepository,
			IHeadHunterClient headHunterClient)
		{
			_vacanciesRepository = vacanciesRepository;
			_headHunterClient = headHunterClient;
		}

		/// <inheritdoc/>
		public async Task UpdateVacancies()
		{
			VacancySearchResult vacanciesResult = await _headHunterClient.GetVacancies();

			IEnumerable<Vacancy> vacancies = await _vacanciesRepository.GetVacancies();

			for (long i = vacanciesResult.Page; i < vacanciesResult.Pages; i++)
			{
				await SeachItems(vacanciesResult, vacancies);
			}
		}

		private async Task SeachItems(VacancySearchResult vacanciesResult, IEnumerable<Vacancy> vacancies)
		{
			foreach (Item vacancyResult in vacanciesResult.Items)
			{
				if (!vacancies.Any(v => v.ExternalId == vacancyResult.Id.ToString() && v.SavingDate == DateTime.Today))
				{
					var vacancy = new Vacancy();
					vacancy.ExternalId = vacancyResult.Id.ToString();
					vacancy.SavingDate = DateTime.Today;
					vacancy.Title = vacancyResult.Name;
					vacancy.Company = await _vacanciesRepository.GetCompany(vacancyResult.Employer.Id.ToString());
					vacancy.Company.Name = vacancyResult.Employer.Name;
					if (vacancyResult.Salary != null)
					{
						vacancy.Salary.From = vacancyResult.Salary.From;
						vacancy.Salary.To = vacancyResult.Salary.To;
						vacancy.Salary.Currency = GetCurrency(vacancyResult.Salary.Currency);
					}

					vacancy.PublicationDate = DateTime.Parse(vacancyResult.PublishedAt);

					await _vacanciesRepository.SaveVacancy(vacancy);
				}
			}
		}

		private static Currency GetCurrency(string value)
		{
			switch (value)
			{
				case "EUR":
					return Currency.Eur;
				case "USD":
					return Currency.Usd;
				default:
					return Currency.Rub;
			}
		}
	}
}
