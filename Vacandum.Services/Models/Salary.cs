using System;

namespace Vacandum.Services.Models
{
	public class Salary
	{
		public Guid Id { get; set; }

		public float From { get; set; }

		public float To { get; set; }

		public Currency Currency { get; set; }
	}
}
