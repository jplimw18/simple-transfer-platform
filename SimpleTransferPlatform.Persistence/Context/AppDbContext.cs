using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Common> CommonUsers { get; set; }
        public DbSet<Shopkeeper> ShopkeeperUsers { get; set; }
    }
}
