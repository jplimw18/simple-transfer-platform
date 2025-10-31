using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IShopkeeperRepository : IBaseRepository<Shopkeeper>, IUserRepository<Shopkeeper>
    {
        Task<Shopkeeper> GetByCnpj(string cnpj, CancellationToken cancellationToken);
    }
}
