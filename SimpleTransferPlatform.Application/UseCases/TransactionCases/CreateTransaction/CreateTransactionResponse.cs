namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;

public sealed record CreateTransactionResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public decimal Amount { get; set; }
    public Guid PayerId { get; set; }
    public Guid PayeeId { get; set; }
}