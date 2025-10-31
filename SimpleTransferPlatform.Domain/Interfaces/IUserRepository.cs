using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User> 
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
