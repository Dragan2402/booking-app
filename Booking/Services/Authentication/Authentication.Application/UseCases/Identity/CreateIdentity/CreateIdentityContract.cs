namespace Booking.Services.Authentication.Application.UseCases.Identity.CreateIdentity;


public class CreateIdentityContract
{
    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string ConfirmPassword { get; set; } = string.Empty;
}