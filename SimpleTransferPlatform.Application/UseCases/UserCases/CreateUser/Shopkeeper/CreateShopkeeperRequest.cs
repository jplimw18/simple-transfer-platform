using MediatR;
using SimpleTransferPlatform.Domain.Entities;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Shopkeeper;

public record CreateShopkeeperRequest(string email, string name, string cnpj) : IRequest<CreateUserResponse>;