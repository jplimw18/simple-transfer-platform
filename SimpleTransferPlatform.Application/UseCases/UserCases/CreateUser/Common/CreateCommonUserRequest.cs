using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Common;

public sealed record CreateCommonUserRequest(string email, string name, string cpf) : IRequest<CreateUserResponse>;