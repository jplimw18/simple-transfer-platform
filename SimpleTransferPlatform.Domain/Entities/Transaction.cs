using SimpleTransferPlatform.Domain.Enums;

namespace SimpleTransferPlatform.Domain.Entities;

public class Transaction : BaseEntity
{
    public CommonUser? Payer { get; private set; }
    public User? Payee { get; private set; }
    public decimal Amount { get; private set; }
    public TransactionStatus Status { get; set; }
    
    
    public void SetPayer(User payer) => Payer = payer as CommonUser;
    public void SetPayee(User payee) => Payee = payee;
    public void SetAsCompleted() => Status = TransactionStatus.Success;
    public void SetAsFailed() => Status = TransactionStatus.Failed;
}