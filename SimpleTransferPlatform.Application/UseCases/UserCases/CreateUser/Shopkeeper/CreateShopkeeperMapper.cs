using AutoMapper;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Common;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Shopkeeper;

public sealed class CreateShopkeeperMapper : Profile
{
    public CreateShopkeeperMapper()
    {
        CreateMap<CreateShopkeeperRequest, ShopkeeperUser>();
        CreateMap<ShopkeeperUser, CreateUserResponse>();
    }
}