﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Vacandum.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}
	}
}
