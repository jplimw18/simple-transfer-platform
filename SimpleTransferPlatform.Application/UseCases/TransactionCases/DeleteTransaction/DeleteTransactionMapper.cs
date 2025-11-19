using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.DeleteTransaction;

public sealed class DeleteTransactionMapper : Profile
{
    public DeleteTransactionMapper()
    {
        CreateMap<DeleteTransactionRequest, Transaction>();
        CreateMap<Transaction, DeleteTransactionResponse>();
    }
}