using AutoMapper;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;

namespace Booking.Services.UserCottage.Application.UseCases.Users.GetUsers;

public class GetUsersUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUsersUseCase(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<UserResult>> Execute()
    {
        var getResult = await _userRepository.GetAllAsync();

        return _mapper.Map<List<UserResult>>(getResult);
    }
}