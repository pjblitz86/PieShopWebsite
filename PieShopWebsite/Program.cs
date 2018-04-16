using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PieShopWebsite.Models;
using System;

namespace PieShopWebsite
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//            BuildWebHost(args).Run();

			var host = BuildWebHost(args);
			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				try
				{
					var context = services.GetRequiredService<AppDbContext>();
					DbInitializer.Seed(context);
				}
				catch (Exception)
				{
					// can implement according to user experience
				}
			}

			host.Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}
