using FluentValidation;
using SimpleTransferPlatform.Application.UseCases.Validations;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser.Shopkeeper;

public class UpdateShopkeeperUserValidator : UpdateUserValidator<ShopkeeperUser>
{
    public UpdateShopkeeperUserValidator() : base()
    {
        RuleFor(x => x.newUser.Cnpj).NotEmpty().IsValidCpfOrCnpj();
    }
}   