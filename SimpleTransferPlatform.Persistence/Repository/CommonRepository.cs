using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class CommonRepository : BaseRepository<Common>, ICommonRepository
    {
        public CommonRepository(AppDbContext context) : base(context) { }

        public Task<Common> GetByCpf(string cpf, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
