using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class ShopkeeperRepository : BaseRepository<ShopkeeperUser>, IShopkeeperRepository
    {
        public ShopkeeperRepository(AppDbContext context) : base(context) { } 

        
        public async Task<ShopkeeperUser> GetByCnpj(string cnpj, CancellationToken cancellationToken)
        {
            return await Context.Set<ShopkeeperUser>().FirstOrDefaultAsync(s => s.Cnpj == cnpj, cancellationToken);
        }

        public async Task<ShopkeeperUser> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Set<ShopkeeperUser>().FirstOrDefaultAsync(s => s.Email == email);
        }
    }
}
