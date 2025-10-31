using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class ShopkeeperRepository : BaseRepository<Shopkeeper>, IShopkeeperRepository
    {
        public ShopkeeperRepository(AppDbContext context) : base(context) { } 

        
        public Task<Shopkeeper> GetByCnpj(string cnpj, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
