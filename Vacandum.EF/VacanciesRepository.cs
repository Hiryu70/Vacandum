using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vacandum.Services.Abstractions;
using Vacandum.Services.Models;

namespace Vacandum.EF
{
	public class VacanciesRepository : IVacanciesRepository
	{
		private readonly VacandumContext _vacandumContext;

		public VacanciesRepository(VacandumContext vacandumContext)
		{
			_vacandumContext = vacandumContext;
		}

		public async Task<IEnumerable<Vacancy>> GetVacancies()
		{
			return await _vacandumContext.Vacancies.ToListAsync();
		}

		public async Task<Company> GetCompany(string externalId)
		{
			var company = await _vacandumContext.Companies.FirstOrDefaultAsync(c => c.ExternalId == externalId);
			company = company ?? new Company { ExternalId = externalId };
			return company;
		}

		public async Task SaveVacancy(Vacancy vacancy)
		{
			await _vacandumContext.Set<Vacancy>().AddAsync(vacancy);
			await _vacandumContext.SaveChangesAsync();
		}
	}
}
