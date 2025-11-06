using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IUserRepository<T> : IBaseRepository<T> where T : User
    {
        Task<T> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
