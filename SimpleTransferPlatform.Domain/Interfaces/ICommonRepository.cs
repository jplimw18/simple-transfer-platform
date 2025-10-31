using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface ICommonRepository : IBaseRepository<Common>
    {
        Task<Common> GetByCpf(string cpf, CancellationToken cancellationToken);
    }
}
