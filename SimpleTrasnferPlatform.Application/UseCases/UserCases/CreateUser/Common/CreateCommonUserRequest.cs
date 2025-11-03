using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTrasnferPlatform.Application.UseCases.UserCases.CreateUser.Common;

public sealed record CreateCommonUserRequest(string email, string name, string cpf) : IRequest<CommonUser>;