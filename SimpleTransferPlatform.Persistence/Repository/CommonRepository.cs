using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class CommonRepository : BaseRepository<Common>, ICommonRepository
    {
        public CommonRepository(AppDbContext context) : base(context) { }

        public async Task<Common> GetByCpf(string cpf, CancellationToken cancellationToken)
        {
            return await Context.Set<Common>().FirstOrDefaultAsync(c => c.Cpf == cpf, cancellationToken);
        }

        public async Task<Common> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Set<Common>().FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
        }
    }
}