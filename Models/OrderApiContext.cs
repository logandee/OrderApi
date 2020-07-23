using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderApiContext : DbContext
    {
        public OrderApiContext(DbContextOptions<OrderApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Product> OrderItem { get; set; }
        public DbSet<Product> Order { get; set; }
    }
}