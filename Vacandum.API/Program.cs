using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Vacandum.API
{
	/// <summary>
	/// Main class of app
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Configuring of App
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			IConfiguration configuration = GetConfiguration();

			Log.Logger = CreateSerilogLogger(configuration);

			try
			{
				CreateWebHostBuilder(configuration, args).Build().Run();
			}
			catch (Exception ex)
			{
				Log.Fatal(ex.Message);
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}

		private static IConfiguration GetConfiguration()
		{
			var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

			IConfigurationBuilder builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{environmentName}.json", true, true)
				.AddEnvironmentVariables();

			return builder.Build();
		}

		private static ILogger CreateSerilogLogger(IConfiguration configuration)
		{
			return new LoggerConfiguration()
				.MinimumLevel.Verbose()
				.WriteTo.Console()
				.ReadFrom.Configuration(configuration)
				.CreateLogger();
		}

		private static IWebHostBuilder CreateWebHostBuilder(IConfiguration configuration, string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.UseConfiguration(configuration)
				.UseSerilog();
		}
	}
}
