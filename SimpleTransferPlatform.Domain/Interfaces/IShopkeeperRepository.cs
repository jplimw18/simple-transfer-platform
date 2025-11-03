using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IShopkeeperRepository : IBaseRepository<ShopkeeperUser>, IUserRepository<ShopkeeperUser>
    {
        Task<ShopkeeperUser> GetByCnpj(string cnpj, CancellationToken cancellationToken);
    }
}
