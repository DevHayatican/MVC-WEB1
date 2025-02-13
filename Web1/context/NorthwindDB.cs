using Microsoft.EntityFrameworkCore;
using Web1.entity;

namespace Web1.context
{
    public class NorthwindDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
               UseSqlServer(
                "server=CAN;database=Northwind;Trusted_connection=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
