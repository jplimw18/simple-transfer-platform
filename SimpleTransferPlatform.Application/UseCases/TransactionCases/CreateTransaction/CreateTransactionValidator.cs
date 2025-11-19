using FluentValidation;

namespace SimpleTransferPlatform.Application.UseCases.TransactionCases.CreateTransaction;

public class CreateTransactionValidator : AbstractValidator<CreateTransactionRequest>
{
    public CreateTransactionValidator()
    {
        RuleFor(x => x.amount).NotEmpty().GreaterThan(0);
    }
}