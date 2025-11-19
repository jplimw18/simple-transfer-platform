using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;

public sealed record CreateTransactionRequest(Guid payerId, Guid payee, decimal amount) : IRequest<CreateTransactionResponse>;