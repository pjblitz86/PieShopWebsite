using Microsoft.EntityFrameworkCore;

namespace PieShopWebsite.Models
{
	public class AppDbContext : DbContext // needed for Entity framework as an agent between code and db
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Pie> Pies { get; set; }
	}
}
