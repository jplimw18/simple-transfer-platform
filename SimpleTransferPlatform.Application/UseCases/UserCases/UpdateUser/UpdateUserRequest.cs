using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser;

public abstract record UpdateUserRequest<T> (T newUser) : IRequest<UpdateUserResponse> where T : User;