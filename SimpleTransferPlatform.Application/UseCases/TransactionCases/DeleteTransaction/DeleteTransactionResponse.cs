namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.DeleteTransaction;

public sealed record DeleteTransactionResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateDeleted { get; set; }
}