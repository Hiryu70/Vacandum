using System;
using System.Threading.Tasks;
using Refit;
using Vacandum.Services.Abstractions;
using Vacandum.Services.Dto;

namespace Vacandum.Services.Services
{
	public sealed class VacancyService : IVacancyService
	{
		public async Task UpdateVacancies()
		{
			var hhApi = RestService.For<IHeadHunterClient>("https://api.hh.ru");
			VacancySearchResult vacancies = await hhApi.GetVacancies();
		}
	}
}
