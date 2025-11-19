using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.DeleteTransaction;

public class DeleteTransactionHandler : IRequestHandler<DeleteTransactionRequest, DeleteTransactionResponse>
{
    private readonly ITransactionRepository _transactionRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DeleteTransactionHandler(ITransactionRepository transactionRepository, IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _transactionRepository = transactionRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<DeleteTransactionResponse> Handle(DeleteTransactionRequest request, CancellationToken cancellationToken)
    {
        var transaction = _mapper.Map<Transaction>(request);
        _transactionRepository.Delete(transaction);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<DeleteTransactionResponse>(transaction);
    }
}