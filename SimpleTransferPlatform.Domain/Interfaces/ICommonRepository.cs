using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface ICommonRepository : IBaseRepository<CommonUser>, IUserRepository<CommonUser>
    {
        Task<CommonUser> GetByCpf(string cpf, CancellationToken cancellationToken);
    }
}
