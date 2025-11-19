namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.UpdateTransaction;

public sealed record UpdateTransactionResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public Guid PayerId { get; set; }
    public Guid PayeeId { get; set; }
}