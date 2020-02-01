using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
		public VacandumContext()
		{
		}

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

		/// <inheritdoc />
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
				if (string.IsNullOrEmpty(environment))
				{
					environment = "Development";
				}

				IConfigurationRoot configuration = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json")
					.AddJsonFile($"appsettings.{environment}.json")
					.Build();

				optionsBuilder.UseMySQL(configuration.GetConnectionString("VacandumConnection"));
			}
		}
	}
}
