using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.DB
{
	public class Context : DbContext
	{
		public DbSet<Models.Person> People { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=Lib.db");
		}
	}
}
