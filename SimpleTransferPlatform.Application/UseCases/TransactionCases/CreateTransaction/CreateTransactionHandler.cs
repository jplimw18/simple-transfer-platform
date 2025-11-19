using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;

public class CreateTransactionHandler : IRequestHandler<CreateTransactionRequest, CreateTransactionResponse>
{
    private readonly ITransactionRepository _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateTransactionHandler(ITransactionRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<CreateTransactionResponse> Handle(CreateTransactionRequest request, CancellationToken cancellationToken)
    {
        var transaction = _mapper.Map<Transaction>(request);
        _repository.Create(transaction);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateTransactionResponse>(transaction);
    }
}