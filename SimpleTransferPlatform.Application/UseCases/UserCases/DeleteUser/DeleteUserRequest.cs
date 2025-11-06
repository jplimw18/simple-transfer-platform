using MediatR;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.DeleteUser;

public sealed record DeleteUserRequest(string email) : IRequest<DeleteUserResponse>;