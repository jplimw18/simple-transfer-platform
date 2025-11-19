using FluentValidation;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.Shared.DTO;

public abstract class BaseValidator<T> : AbstractValidator<T> where T : BaseEntity
{
    protected BaseValidator()
    {
        RuleFor(x => x).NotEmpty()
            .WithMessage("{PropertyName} can not be empty");
        
        RuleFor(x => x.Id).NotEmpty()
            .WithMessage("{PropertyName} can not be empty");;
    }
}