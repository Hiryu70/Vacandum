using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vacandum.Services.Abstractions;

namespace Vacandum.EF
{
	/// <summary>
	/// Extension of data access layer.
	/// </summary>
	public static class VacandumEfExtensions
	{
		/// <summary>
		/// Add data access layer.
		/// </summary>
		/// <param name="services">Collection of services.</param>
		/// <param name="connectionString">Database connection string.</param>
		/// <returns>Collections of services.</returns>
		public static IServiceCollection AddDal(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<VacandumContext>(options => options
				.UseMySQL(connectionString));

			services.AddScoped<IVacanciesRepository, VacanciesRepository>();

			return services;
		}
	}
}
