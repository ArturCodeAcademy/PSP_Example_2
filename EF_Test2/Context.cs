using Microsoft.EntityFrameworkCore;
using Models;

public class Context : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    public Context()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // DESKTOP-8CVDJ80\SQLEXPRESS - your server name / connection string
        //optionsBuilder.UseSqlServer("Server=DESKTOP-8CVDJ80\\SQLEXPRESS;Database=EF_Test2;Trusted_Connection=True;");

        optionsBuilder.UseSqlite("Data Source=EF_Test2.db");
	}

}