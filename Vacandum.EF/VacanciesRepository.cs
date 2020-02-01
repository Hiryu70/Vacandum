using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vacandum.Services.Abstractions;
using Vacandum.Services.Models;

namespace Vacandum.EF
{
	/// <inheritdoc />
	public class VacanciesRepository : IVacanciesRepository
	{
		private readonly VacandumContext _vacandumContext;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="vacandumContext">Context of database.</param>
		public VacanciesRepository(VacandumContext vacandumContext)
		{
			_vacandumContext = vacandumContext;
		}

		/// <inheritdoc />
		public async Task<IEnumerable<Vacancy>> GetVacancies()
		{
			return await _vacandumContext.Vacancies.ToListAsync();
		}

		/// <inheritdoc />
		public async Task<Company> GetCompany(string externalId)
		{
			var company = await _vacandumContext.Companies.FirstOrDefaultAsync(c => c.ExternalId == externalId);
			company = company ?? new Company { ExternalId = externalId };
			return company;
		}

		/// <inheritdoc />
		public async Task SaveVacancy(Vacancy vacancy)
		{
			await _vacandumContext.Set<Vacancy>().AddAsync(vacancy);
			await _vacandumContext.SaveChangesAsync();
		}
	}
}
