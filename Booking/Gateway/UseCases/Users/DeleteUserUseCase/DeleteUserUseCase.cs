using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.UserCottageContract.Interfaces;

namespace Booking.Gateway.UseCases.Users.DeleteUserUseCase;

public class DeleteUserUseCase
{
    private readonly IUserService _userService;
    private readonly IIdentityService _identityService;

    public DeleteUserUseCase(IUserService userService, IIdentityService identityService)
    {
        this._userService = userService;
        this._identityService = identityService;
    }

    public async Task Execute(Guid userId)
    {
        var response = await _userService.DeleteUser(new DeleteObjectRequest() { Id = userId });

        await _identityService.DeleteIdentity(new DeleteObjectRequest() { Id = response.IdentityId });
    }
}