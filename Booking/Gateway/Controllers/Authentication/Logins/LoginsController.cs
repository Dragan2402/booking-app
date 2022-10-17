using AutoMapper;
using Booking.Gateway.Controllers.Authentication.Logins.Requests;
using Booking.Gateway.Controllers.Authentication.Logins.Responses;
using Booking.Gateway.Controllers.Authorization._Common;
using Booking.Gateway.UseCases.Logins.Login;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Controllers.Authentication.Logins;

[ApiController]
public class LoginsController : Controller
{
    private readonly IMapper _mapper;

    public LoginsController(IMapper mapper)
    {
        this._mapper = mapper;
    }

    [Route("api/login")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginGatewayResponse))]
    public async Task<IActionResult> Login(
        [FromServices] LoginUseCase loginUseCase,
        [FromHeader(Name = "Origin")] string origin,
        [FromBody] LoginGatewayRequest request
        )
    {
        LoginContract contract = _mapper.Map<LoginContract>(request);
        contract.Origin = origin;

        var result = await loginUseCase.Execute(contract);

        return Ok(_mapper.Map<LoginGatewayResponse>(result));
    }

    [Route("api/logout")]
    [HttpPost]
    [BearerAuthorization]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Logout()
    {
        return NoContent();
    }
}

