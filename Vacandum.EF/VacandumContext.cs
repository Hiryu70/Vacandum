using Microsoft.EntityFrameworkCore;
using Vacandum.Services.Models;

namespace Vacandum.EF
{
	public class VacandumContext : DbContext
	{
		public DbSet<Vacancy> Vacancies { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL(@"server=127.0.0.1;uid=root;pwd=;database=vacandum");
		}
	}
}
