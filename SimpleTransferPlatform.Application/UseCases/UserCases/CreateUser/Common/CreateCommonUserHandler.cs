using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser.Common;

public class CreateCommonUserHandler : IRequestHandler<CreateCommonUserRequest,  CreateUserResponse>
{
    private readonly ICommonRepository _commonUserRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCommonUserHandler(IUnitOfWork unitOfWork, ICommonRepository userRepository, IMapper mapper)
    {
        _commonUserRepository = userRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<CreateUserResponse> Handle(CreateCommonUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<CommonUser>(request);
        _commonUserRepository.Create(user);
        
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateUserResponse>(user);
    }
}