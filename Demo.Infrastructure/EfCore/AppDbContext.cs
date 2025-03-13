using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.EfCore
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-EFOC9MRP7RE;Database=Pb304DemoDb;Trusted_Connection=True;TrustServerCertificate=true");
        }


    }
}
