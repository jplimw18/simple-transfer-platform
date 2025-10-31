using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IShopkeeperRepository : IBaseRepository<Shopkeeper>
    {
        Task<Shopkeeper> GetByCnpj(string cnpj, CancellationToken cancellationToken);
    }
}
