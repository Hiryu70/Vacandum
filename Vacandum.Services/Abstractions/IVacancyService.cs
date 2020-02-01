using System.Threading.Tasks;

namespace Vacandum.Services.Abstractions
{
	/// <summary>
	/// Vacancies service.
	/// </summary>
	public interface IVacancyService
	{
		/// <summary>
		/// Get vacancies from Api and save to database.
		/// </summary>
		/// <returns>None.</returns>
		Task UpdateVacancies();
	}
}
