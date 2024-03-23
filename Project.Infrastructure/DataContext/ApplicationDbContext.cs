using Microsoft.EntityFrameworkCore;
using Project.Domail.Entities;

namespace Project.Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<ProductSize>? productSizes { get; set; }
        public DbSet<Retailer> ? railers { get; set; }
    }
}
