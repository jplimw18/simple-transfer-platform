using FluentValidation;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser;

public abstract class UpdateUserValidator<T> : AbstractValidator<UpdateUserRequest<T>> where T : User 
{
    public UpdateUserValidator()
    {
        RuleFor(x => x.newUser.Email).NotEmpty().MaximumLength(100).EmailAddress();
        RuleFor(x => x.newUser.Name).NotEmpty().MinimumLength(3).MaximumLength(100);
    }
}