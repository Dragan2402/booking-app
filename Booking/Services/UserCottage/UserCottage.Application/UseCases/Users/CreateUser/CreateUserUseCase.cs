using AutoMapper;
using Booking.Services.Common.Domain;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;

public class CreateUserUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateUserUseCase(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._userRepository = userRepository;
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<Guid> Execute(CreateUserContract contract)
    {
        var user = _mapper.Map<User>(contract);

        await _userRepository.CreateAsync(user);

        await _unitOfWork.CommitAsync();

        return user.Id;
    }
}