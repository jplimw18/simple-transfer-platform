using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.DeleteUser;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}