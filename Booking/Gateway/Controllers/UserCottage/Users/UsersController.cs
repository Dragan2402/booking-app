using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Cottages.Requests;
using Booking.Gateway.Controllers.UserCottage.Users.Requests;
using Booking.Gateway.Controllers.UserCottage.Users.Responses;
using Booking.Gateway.UseCases.Users.CreateUserUseCase;
using Booking.Gateway.UseCases.Users.DeleteUserUseCase;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.UserCottageContract.Interfaces;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Booking.Grpc.UserCottageContract.Requests;
using Microsoft.AspNetCore.Mvc;
using Booking.Grpc.UserCottageContract.Requests.Users;

namespace Booking.Gateway.Controllers.UserCottage.Users;

[Route("api/users")]
[ApiController]
public class UsersController : Controller
{
    private readonly IMapper _mapper;
    public UsersController(IMapper mapper)
    {
        this._mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserGatewayResponse>))]
    public async Task<IActionResult> GetAllUsers([FromServices] IUserService userService)
    {
        var result = await userService.GetAllUsers();
        var response = _mapper.Map<List<UserGatewayResponse>>(result);
        return Ok(response);
    }

    [HttpGet]
    [Route("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserGatewayResponse))]
    public async Task<IActionResult> GetUserById(
    [FromServices] IUserService userService,
    [FromRoute] Guid userId
    )
    {
        var result = await userService.GetUserById(new GetObjectRequest() { Id = userId });
        var response = _mapper.Map<UserGatewayResponse>(result);
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateUser(
        [FromServices] CreateUserUseCase createUserUseCase,
        [FromBody] CreateUserGatewayRequest request
        )
    {
        var response = await createUserUseCase.Execute(request);

        return Created(Request.Path, response.Id);
    }

    [HttpPut]
    [Route("{userId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateUser(
        [FromServices] IUserService userService,
        [FromRoute] Guid userId,
        [FromBody] UpdateUserGatewayRequest request
        )
    {
        await userService.UpdateUser(new UpdateUserRequest()
        {
            Id = userId,
            UserRequest = _mapper.Map<UpdateUserUserRequest>(request)
        });
        return NoContent();
    }

    [HttpDelete]
    [Route("{userId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> DeleteUser(
        [FromServices] DeleteUserUseCase deleteUserUseCase,
        [FromRoute] Guid userId)
    {
        await deleteUserUseCase.Execute(userId);

        return NoContent();
    }
}

