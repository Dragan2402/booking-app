using ProtoBuf;

namespace Booking.Grpc._Common.Grpc.Responses;

[ProtoContract]
public class AddressResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public string Street { get; set; } = string.Empty;

    [ProtoMember(3)]
    public string City { get; set; } = string.Empty;

    [ProtoMember(4)]
    public string PostalCode { get; set; } = string.Empty;

    [ProtoMember(5)]
    public string State { get; set; } = string.Empty;

    [ProtoMember(6)]
    public string Country { get; set; } = string.Empty;

    [ProtoMember(7)]
    public string CreatedAt { get; set; } = string.Empty;

    [ProtoMember(8)]
    public string UpdatedAt { get; set; } = string.Empty;
}