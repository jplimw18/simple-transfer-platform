using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository;

public class TransactionRepository : BaseRepository<Transaction>
{
    public TransactionRepository(AppDbContext context) : base(context) { }
}