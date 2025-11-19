using FluentValidation;
using SimpleTransferPlatform.Application.UseCases.CustomValidations;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser.Common;

public class UpdateCommonUserValidator : UpdateUserValidator<CommonUser>
{
    public UpdateCommonUserValidator() : base()
    {
        RuleFor(x => x.newUser.Cpf).NotEmpty().IsValidCpfOrCnpj();
    }
}