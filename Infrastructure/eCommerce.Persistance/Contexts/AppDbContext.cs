using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Persistance.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(p => p.Orders).WithMany(o => o.Products);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<Product> Products { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}
