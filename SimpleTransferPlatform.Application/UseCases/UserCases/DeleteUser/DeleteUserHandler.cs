using AutoMapper;
using MediatR;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;

namespace SimpleTransferPlatform.Application.UseCases.UserCases.DeleteUser;

public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
{
    private readonly IUserRepository<User>  _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DeleteUserHandler(IUserRepository<User> userRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        _userRepository.Delete(user);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<DeleteUserResponse>(user);
    }
}