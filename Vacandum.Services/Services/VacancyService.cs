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
			VacancySearchResult siteVacanciesResult = await _headHunterClient.GetVacancies();
			IEnumerable<Vacancy> dbVacancies = await _vacanciesRepository.GetVacancies();

			foreach (Item siteVacancy in siteVacanciesResult.Items)
			{
				SaveVacancy(siteVacancy, dbVacancies);
			}
		}

		private async void SaveVacancy(Item siteVacancy, IEnumerable<Vacancy> dbVacancies)
		{
			if (!dbVacancies.Any(v => v.ExternalId == siteVacancy.Id.ToString() && v.SavingDate == DateTime.Today))
			{
				var dbVacancy = new Vacancy();
				dbVacancy.ExternalId = siteVacancy.Id.ToString();
				dbVacancy.SavingDate = DateTime.Today;
				dbVacancy.Title = siteVacancy.Name;
				dbVacancy.Company = await _vacanciesRepository.GetCompany(siteVacancy.Employer.Id.ToString());
				dbVacancy.Company.Name = siteVacancy.Employer.Name;
				FillSalaryData(dbVacancy, siteVacancy);
				dbVacancy.PublicationDate = DateTime.Parse(siteVacancy.PublishedAt);

				await _vacanciesRepository.SaveVacancy(dbVacancy);
			}
		}

		private void FillSalaryData(Vacancy dbVacancy, Item siteVacancy)
		{
			if (siteVacancy.Salary != null)
			{
				dbVacancy.Salary.From = siteVacancy.Salary.From;
				dbVacancy.Salary.To = siteVacancy.Salary.To;
				dbVacancy.Salary.Currency = GetCurrency(siteVacancy.Salary.Currency);
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
