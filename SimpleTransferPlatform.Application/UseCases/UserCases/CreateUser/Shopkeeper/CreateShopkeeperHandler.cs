using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Shopkeeper;

public class CreateShopkeeperHandler : IRequestHandler<CreateShopkeeperRequest, CreateUserResponse>
{
    private readonly IUserRepository<ShopkeeperUser> _userRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateShopkeeperHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopkeeperRepository userRepository)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<CreateUserResponse> Handle(CreateShopkeeperRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<ShopkeeperUser>(request);
        _userRepository.Create(user);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateUserResponse>(user);
    }
}