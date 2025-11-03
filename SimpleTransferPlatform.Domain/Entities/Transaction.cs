using SimpleTransferPlatform.Domain.Enums;

namespace SimpleTransferPlatform.Domain.Entities;

public class Transaction : BaseEntity
{
    public Guid PayerId { get; private set; }
    public Guid PayeeId { get; private set; }
    public decimal Amount { get; private set; }
    public TransactionStatus Status { get; set; }
    
    private Transaction() { }

    public Transaction(Guid payerId, Guid payeeId, decimal amount)
    {
        PayerId = payerId;
        PayeeId = payeeId;
        Amount = amount;
        Status = TransactionStatus.Pending;
    }

    public void SetAsCompleted() => Status = TransactionStatus.Success;
    public void SetAsFailed() => Status = TransactionStatus.Failed;
}