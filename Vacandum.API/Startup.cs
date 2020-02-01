using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Vacandum.EF;
using Vacandum.Services.Abstractions;
using Vacandum.Services.Services;

namespace Vacandum.API
{
	/// <summary>
	/// Startup
	/// </summary>
	public class Startup
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="configuration"></param>
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		private IConfiguration Configuration { get; }

		/// <summary>
		/// Configure services of App
		/// </summary>
		/// <param name="services">Collection of services</param>
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("vacandum", new OpenApiInfo
				{
					Title = "Vacandum API"
				});

				var docFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var docFilePath = Path.Combine(AppContext.BaseDirectory, docFile);

				c.IncludeXmlComments(docFilePath);
			});

			services.AddDal(Configuration.GetConnectionString("VacandumConnection"));
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			services.AddScoped<IVacancyService, VacancyService>();
		}

		/// <summary>
		/// Configure App
		/// </summary>
		/// <param name="app">Configurator of App</param>
		/// <param name="env">Hosting environment</param>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/vacandum/swagger.json", "Vacandum API");
				c.RoutePrefix = "api/vacandum/swagger";
			});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
