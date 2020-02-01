using Microsoft.EntityFrameworkCore;
using Vacandum.Services.Models;

namespace Vacandum.EF
{
	/// <summary>
	/// Database context.
	/// </summary>
	public class VacandumContext : DbContext
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="options">Parameters of context creation.</param>
		public VacandumContext(DbContextOptions<VacandumContext> options)
			: base(options)
		{
		}

		/// <summary>
		/// Vacancies.
		/// </summary>
		public DbSet<Vacancy> Vacancies { get; set; }

		/// <summary>
		/// Companies.
		/// </summary>
		public DbSet<Company> Companies { get; set; }
	}
}
