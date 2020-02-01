using System.Collections.Generic;
using System.Threading.Tasks;
using Vacandum.Services.Models;

namespace Vacandum.Services.Abstractions
{
	public interface IVacanciesRepository
	{
		Task<IEnumerable<Vacancy>> GetVacancies();

		Task<Company> GetCompany(string externalId);

		Task SaveVacancy(Vacancy vacancy);
	}
}
