using System.Threading.Tasks;
using Refit;
using Vacandum.Services.Dto;

namespace Vacandum.Services.Abstractions
{
	[Headers("User-Agent: My-App")]
	public interface IHeadHunterClient
	{
		[Get("/vacancies?area=66&text=c%23")]
		Task<VacancySearchResult> GetVacancies();
	}
}
