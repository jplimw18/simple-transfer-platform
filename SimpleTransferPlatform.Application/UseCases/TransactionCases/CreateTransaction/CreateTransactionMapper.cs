using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;

public sealed class CreateTransactionMapper : Profile
{
    public  CreateTransactionMapper()
    {
        CreateMap<CreateTransactionRequest, Transaction>();
        CreateMap<Transaction, CreateTransactionResponse>();
    }
}