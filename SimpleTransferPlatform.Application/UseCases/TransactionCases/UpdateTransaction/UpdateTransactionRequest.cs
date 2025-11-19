using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.UpdateTransaction;

public sealed record UpdateTransactionRequest(Guid transcationId, Transaction transaction) : IRequest<UpdateTransactionResponse>;