using Booking.Grpc._Common.Grpc.Responses;

namespace Booking.Gateway.Controllers.UserCottage.Cottages.Responses;

public class CottageGatewayResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public AddressResponse Address { get; set; } = default!;
}