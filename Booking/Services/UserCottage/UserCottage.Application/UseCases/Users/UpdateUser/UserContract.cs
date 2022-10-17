using Booking.Services.UserCottage.Application.UseCases._Common.Requests;

namespace Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;

public class UserContract
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public AddressContract? Address { get; set; }
}
