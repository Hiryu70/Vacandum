using Microsoft.EntityFrameworkCore;
using Vacandum.Services.Models;

namespace Vacandum.EF
{
	public class VacandumContext : DbContext
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="options">Параметры создания контекста.</param>
		public VacandumContext(DbContextOptions<VacandumContext> options)
			: base(options)
		{
		}

		public DbSet<Vacancy> Vacancies { get; set; }
		public DbSet<Company> Companies { get; set; }
	}
}
