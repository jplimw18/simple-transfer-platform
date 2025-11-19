using AutoMapper;
using SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.UpdateTransaction;

public sealed class UpdateTransactionMapper : Profile
{
    public UpdateTransactionMapper()
    {
        CreateMap<UpdateTransactionRequest, Transaction>();
        CreateMap<Transaction, UpdateTransactionResponse>();
    }
}