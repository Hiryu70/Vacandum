using System.Collections.Generic;
using System.Threading.Tasks;
using Vacandum.Services.Models;

namespace Vacandum.Services.Abstractions
{
	/// <summary>
	/// Vacancies repository.
	/// </summary>
	public interface IVacanciesRepository
	{
		/// <summary>
		/// Get all vacancies.
		/// </summary>
		/// <returns>List of all vacancies.</returns>
		Task<IEnumerable<Vacancy>> GetVacancies();

		/// <summary>
		/// Get company by it external Id.
		/// </summary>
		/// <param name="externalId">Id in external api.</param>
		/// <returns>Company.</returns>
		Task<Company> GetCompany(string externalId);

		/// <summary>
		/// Save vacancy to database.
		/// </summary>
		/// <param name="vacancy">Vacancy.</param>
		/// <returns>None.</returns>
		Task SaveVacancy(Vacancy vacancy);
	}
}
