using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Shopkeeper;

public class CreateShopkeeperHandler : IRequestHandler<CreateShopkeeperRequest, CreateUserResponse>
{
    private readonly IShopkeeperRepository _shopkeeperRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateShopkeeperHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopkeeperRepository shopkeeperRepository)
    {
        _shopkeeperRepository = shopkeeperRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<CreateUserResponse> Handle(CreateShopkeeperRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<ShopkeeperUser>(request);
        _shopkeeperRepository.Create(user);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateUserResponse>(user);
    }
}