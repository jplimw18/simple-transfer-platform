using FluentValidation;
using SimpleTransferPlatform.Application.Shared.DTO.UserDTO;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.Shared.DTO.TransactionDTO;

public sealed class TransactionValidator : BaseValidator<Transaction>
{
    public TransactionValidator() : base()
    {
        RuleFor(x => x.Amount).NotEmpty()
            .WithMessage("{PropertyName} is required")
            .GreaterThan(0)
            .WithMessage("{PropertyName} must be greater than zero");
        
        RuleFor(x => x.Payer)
            .SetValidator(new UserValidator<CommonUser>()!);

        RuleFor(x => x.Payee)
            .SetValidator(new UserValidator<User>()!);
    }
}