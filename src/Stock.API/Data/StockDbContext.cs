using Microsoft.EntityFrameworkCore;
using Stock.API.Models;

namespace Stock.API.Data
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
