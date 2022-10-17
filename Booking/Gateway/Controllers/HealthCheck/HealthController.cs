using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Controllers.HealthChecks;

[Route("api/health")]
[ApiController]
public class HealthController : Controller
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    public Task<IActionResult> HealthCheck()
    {
        return Task.FromResult<IActionResult>(this.Ok("OK"));
    }
}
