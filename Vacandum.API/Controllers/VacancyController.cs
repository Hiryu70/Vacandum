using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vacandum.Services.Abstractions;

namespace Vacandum.API.Controllers
{
	/// <summary>
	/// Vacancies controller.
	/// </summary>
	[Route("api/vacancy")]
	[ApiController]
	public class VacancyController : ControllerBase
	{
		private readonly IVacancyService _vacancyService;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="vacancyService">Vacancy service.</param>
		public VacancyController(IVacancyService vacancyService)
		{
			_vacancyService = vacancyService;
		}

		/// <summary>
		/// Update vacancies in database from site.
		/// </summary>
		/// <returns>Text info.</returns>
		[HttpPost]
		[Route("update")]
		[ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
		public async Task<ActionResult<string>> UpdateVacancies()
		{
			await _vacancyService.UpdateVacancies();

			return Ok("Vacancies updated");
		}
	}
}
