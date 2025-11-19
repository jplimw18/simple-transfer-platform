using FluentValidation;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.UpdateTransaction;

public class UpdateTransactionValidator : AbstractValidator<UpdateTransactionRequest>
{
    public UpdateTransactionValidator()
    {
        RuleFor(x => x.transcationId).NotEmpty();
    }
}