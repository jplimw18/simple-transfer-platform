using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser;

public sealed class UpdateUserMapper<T> : Profile where T : User
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserRequest<T>, T>();
        CreateMap<T, UpdateUserResponse>();
    }
}