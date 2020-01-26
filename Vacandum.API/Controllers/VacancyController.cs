using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Vacandum.API.Controllers
{
	[Route("api/vacancy")]
	[ApiController]
	public class VacancyController : ControllerBase
	{
		[HttpGet]
		[Route("test")]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}
	}
}
