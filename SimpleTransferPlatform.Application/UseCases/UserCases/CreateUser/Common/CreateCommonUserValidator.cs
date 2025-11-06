using FluentValidation;
using SimpleTransferPlatform.Application.UseCases.Validations;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Common;

public class CreateCommonUserValidator : AbstractValidator<CreateCommonUserRequest>
{
    public CreateCommonUserValidator()
    {
        RuleFor(x => x.email).NotEmpty().MaximumLength(100).EmailAddress();
        RuleFor(x => x.name).NotEmpty().MinimumLength(3).MaximumLength(100);
        RuleFor(x => x.cpf).NotEmpty().IsValidCpfOrCnpj();
    }
}