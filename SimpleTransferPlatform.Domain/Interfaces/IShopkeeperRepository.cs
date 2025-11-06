using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IShopkeeperRepository : IUserRepository<ShopkeeperUser>
    {
        Task<ShopkeeperUser> GetByCnpj(string cnpj, CancellationToken cancellationToken);
    }
}
