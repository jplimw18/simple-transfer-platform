using MediatR;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.DeleteTransaction;

public record DeleteTransactionRequest(Guid Id) : IRequest<DeleteTransactionResponse>;