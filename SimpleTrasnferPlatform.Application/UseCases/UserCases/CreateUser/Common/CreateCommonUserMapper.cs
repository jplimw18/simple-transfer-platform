using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTrasnferPlatform.Application.UseCases.UserCases.CreateUser.Common;

public sealed class CreateCommonUserMapper : Profile
{
    public CreateCommonUserMapper()
    {
        CreateMap<CreateCommonUserRequest, CommonUser>();
        CreateMap<CommonUser, CreateUserResponse>();
    }
}