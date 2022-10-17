using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Booking.Gateway.Controllers.Authorization._Common;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
public class BearerAuthorizationAttribute : Attribute, IAsyncAuthorizationFilter
{
    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        var origin = context.HttpContext.Request.ExtractOrigin();
        var token = context.HttpContext.Request.ExtractToken();

        var validationClient = context.HttpContext.RequestServices.GetService<ITokenValidationService>().EnsureNotNull();

        await validationClient.ValidateAccessToken(
                new ValidateAccessTokenRequest { Origin = origin, Token = token });
    }
}
