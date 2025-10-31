using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IUserRepository<T> where T : User
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
