using Booking.Services.UserCottage.Application.UseCases._Common.Requests;
using Booking.Services.UserCottage.Domain.Models.Enum;

namespace Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;

public class CreateUserContract
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public Guid IdentityId { get; set; }

    public EUserType UserType { get; set; }

    public AddressContract Address = default!;
}