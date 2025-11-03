using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class CommonRepository : BaseRepository<CommonUser>, ICommonRepository
    {
        public CommonRepository(AppDbContext context) : base(context) { }

        public async Task<CommonUser> GetByCpf(string cpf, CancellationToken cancellationToken)
        {
            return await Context.Set<CommonUser>().FirstOrDefaultAsync(c => c.Cpf == cpf, cancellationToken);
        }

        public async Task<CommonUser> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Set<CommonUser>().FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
        }
    }
}