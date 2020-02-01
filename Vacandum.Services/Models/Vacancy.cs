using System;

namespace Vacandum.Services.Models
{
	/// <summary>
	/// Vacancy.
	/// </summary>
	public class Vacancy
	{
		/// <summary>
		/// Vacancy Id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Vacancy Id in external api.
		/// </summary>
		public string ExternalId { get; set; } 

		/// <summary>
		/// Date of saving vacancy in database.
		/// </summary>
		public DateTime SavingDate { get; set; }

		/// <summary>
		/// Title of vacancy.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Salary.
		/// </summary>
		public Salary Salary { get; set; } = new Salary();

		/// <summary>
		/// Working experience.
		/// </summary>
		public Experience Experience { get; set; }

		/// <summary>
		/// Date of publishing vacancy on api.
		/// </summary>
		public DateTime PublicationDate { get; set; } 

		/// <summary>
		/// Employer company.
		/// </summary>
		public Company Company { get; set; } = new Company();

		/// <summary>
		/// Page.
		/// </summary>
		public long Page { get; set; }
	}
}
