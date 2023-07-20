using Booking.Services.UserCottage.Application.UseCases._Common.Requests;

namespace Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;

public class CreateUserContract
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public Guid IdentityId { get; set; }

    public string Role { get; set; } = string.Empty;

    public AddressContract Address = default!;
}