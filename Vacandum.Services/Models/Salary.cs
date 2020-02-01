using System;

namespace Vacandum.Services.Models
{
	/// <summary>
	/// Month salary.
	/// </summary>
	public class Salary
	{
		/// <summary>
		/// Salary Id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Lower bound of salary.
		/// </summary>
		public float? From { get; set; }

		/// <summary>
		/// Upper bound of salary.
		/// </summary>
		public float? To { get; set; }

		/// <summary>
		/// Currency of salary.
		/// </summary>
		public Currency Currency { get; set; }
	}
}
