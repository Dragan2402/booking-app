namespace Booking.Services.Authentication.Application.UseCases.TokenValidation;

public class ValidateAccessTokenContract
{
    public string Token { get; set; } = string.Empty;

    public string Origin { get; set;  } = string.Empty;
}