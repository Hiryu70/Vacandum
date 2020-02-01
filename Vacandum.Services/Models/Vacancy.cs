using System;

namespace Vacandum.Services.Models
{
	public class Vacancy
	{
		public Guid Id { get; set; }

		public string ExternalId { get; set; } 

		public DateTime SavingDate { get; set; }

		public string Title { get; set; }

		public Salary Salary { get; set; } = new Salary();

		public Experience Experience { get; set; }

		public DateTime PublicationDate { get; set; } 

		public Company Company { get; set; } = new Company();
	}
}
