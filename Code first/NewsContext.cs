using EFD2.models;
using Microsoft.EntityFrameworkCore;

namespace EFD2.models
{
    public class NewsContext : DbContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=NewsDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
