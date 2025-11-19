using FluentValidation;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.DeleteTransaction;

public class DeleteTransactionValidator : AbstractValidator<DeleteTransactionRequest>
{
    public DeleteTransactionValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}