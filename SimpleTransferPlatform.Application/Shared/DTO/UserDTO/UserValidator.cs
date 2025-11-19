using FluentValidation;
using SimpleTransferPlatform.Application.UseCases.CustomValidations;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.Shared.DTO.UserDTO;

public class UserValidator<T> : BaseValidator<T> where T : User
{
    public UserValidator() : base()
    {
        RuleFor(x => x).NotEmpty()
            .WithMessage("{PropertyName} can not be empty");
        
        RuleFor(x => x.Name).NotEmpty()
                .WithMessage("{PropertyName} can not be empty")
            .MinimumLength(2)
                .WithMessage("{PropertyName} must have at least 2 characters")
            .MaximumLength(255)
                .WithMessage("{PropertyName} must not exceed 255 characters");
        
        RuleFor(x => x.Email).NotEmpty()
                .WithMessage("{PropertyName} can not be empty")
            .EmailAddress()
                .WithMessage("{PropertyName} can not be empty");

        if (typeof(T) == typeof(CommonUser))
            RuleFor(x => (x as CommonUser)!.Cpf)
                .IsValidCpfOrCnpj();
        
        else if (typeof(T) == typeof(ShopkeeperUser))
            RuleFor(x => (x as ShopkeeperUser)!.Cnpj)
                .IsValidCpfOrCnpj();
    }
}