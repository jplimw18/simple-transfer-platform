using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class ShopkeeperRepository : BaseRepository<Shopkeeper>, IShopkeeperRepository
    {
        public ShopkeeperRepository(AppDbContext context) : base(context) { } 

        
        public async Task<Shopkeeper> GetByCnpj(string cnpj, CancellationToken cancellationToken)
        {
            return await Context.Set<Shopkeeper>().FirstOrDefaultAsync(s => s.Cnpj == cnpj, cancellationToken);
        }

        public async Task<Shopkeeper> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Set<Shopkeeper>().FirstOrDefaultAsync(s => s.Email == email);
        }
    }
}
