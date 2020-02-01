using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vacandum.Services.Abstractions;

namespace Vacandum.EF
{
	public static class VacandumEfExtensions
	{
		public static IServiceCollection AddDal(this IServiceCollection services, string notificationsConnectionStrings)
		{
			services.AddDbContext<VacandumContext>(options => options
				.UseMySQL(notificationsConnectionStrings));

			services.AddScoped<IVacanciesRepository, VacanciesRepository>();

			return services;
		}
	}
}
