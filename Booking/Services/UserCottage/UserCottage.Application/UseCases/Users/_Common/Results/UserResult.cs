using Booking.Services.UserCottage.Application.UseCases._Common.Results;


namespace Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;

public class UserResult
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Guid IdentityId { get; set; }
    public string Role { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public AddressResult Address { get; set; } = default!;
}