using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Users.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.UserCottageContract.Interfaces;
using Booking.Grpc.UserCottageContract.Requests.Users;

namespace Booking.Gateway.UseCases.Users.CreateUserUseCase;

public class CreateUserUseCase
{
    private readonly IMapper _mapper;
    private readonly IUserService _userService;
    private readonly IIdentityService _identityService;

    public CreateUserUseCase(IMapper mapper, IUserService userService, IIdentityService identityService)
    {
        this._mapper = mapper;
        this._userService = userService;
        this._identityService = identityService;
    }

    public async Task<CreateObjectResponse> Execute(CreateUserGatewayRequest request)
    {
        var identityResponse = await _identityService.CreateIdentity(_mapper.Map<CreateIdentityRequest>(request.CreateUserIdentityGatewayRequest));

        var createUserRequest = _mapper.Map<CreateUserRequest>(request.UserGatewayRequest);
        createUserRequest.IdentityId = identityResponse.Id;

        var response = await _userService.CreateUser(createUserRequest);

        return response;
    }
}