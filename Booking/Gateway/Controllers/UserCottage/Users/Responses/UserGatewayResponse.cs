using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract;

namespace Booking.Gateway.Controllers.UserCottage.Users.Responses;

public class UserGatewayResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Guid IdentityId { get; set; }
    public string Role { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public AddressResponse Address { get; set; } = default!;
}