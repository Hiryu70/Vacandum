using System.Threading.Tasks;
using Refit;
using Vacandum.Services.Dto;

namespace Vacandum.Services.Abstractions
{
	/// <summary>
	/// Client for Head Hunter Api.
	/// </summary>
	[Headers("User-Agent: My-App")]
	public interface IHeadHunterClient
	{
		/// <summary>
		/// Get list of vacancies for Nijniy Novgorod and "C#" query.
		/// </summary>
		/// <returns>VacancySearchResult.</returns>
		[Get("/vacancies?area=66&text=c%23")]
		Task<VacancySearchResult> GetVacancies();
	}
}
