using FluentValidation;
using SimpleTransferPlatform.Application.UseCases.Extensions;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Shopkeeper;

public class CreateShopkeeperValidator : AbstractValidator<CreateShopkeeperRequest>
{
    public CreateShopkeeperValidator()
    {
        RuleFor(x => x.email).NotEmpty().MaximumLength(100).EmailAddress();
        RuleFor(x => x.name).NotEmpty().MinimumLength(3).MaximumLength(100);
        RuleFor(x => x.cnpj).NotEmpty().IsValidCpfOrCnpj();
    }
}