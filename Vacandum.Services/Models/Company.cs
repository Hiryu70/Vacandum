using System;

namespace Vacandum.Services.Models
{
	/// <summary>
	/// Company.
	/// </summary>
	public class Company
	{
		/// <summary>
		/// Company Id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Company name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Company Id from external api.
		/// </summary>
		public string ExternalId { get; set; }
	}
}
