using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vacandum.Services.Abstractions;

namespace Vacandum.API.Controllers
{
	[Route("api/vacancy")]
	[ApiController]
	public class VacancyController : ControllerBase
	{
		private readonly IVacancyService _vacancyService;

		public VacancyController(IVacancyService vacancyService)
		{
			_vacancyService = vacancyService;
		}


		[HttpGet]
		[Route("test")]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[HttpPost]
		[Route("update")]
		public ActionResult<string> UpdateVacancies()
		{
			_vacancyService.UpdateVacancies();


			return "Вакансии обновлены";
		}
	}
}
