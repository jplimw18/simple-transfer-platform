using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CommonUser> CommonUsers { get; set; }
        public DbSet<ShopkeeperUser> ShopkeeperUsers { get; set; }
    }
}
