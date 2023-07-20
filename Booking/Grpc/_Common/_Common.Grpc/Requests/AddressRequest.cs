using ProtoBuf;

namespace Booking.Grpc._Common.Grpc.Requests;

[ProtoContract]
public class AddressRequest
{
    [ProtoMember(1)]
    public string Street { get; set; } = string.Empty;

    [ProtoMember(3)]
    public string City { get; set; } = string.Empty;

    [ProtoMember(4)]
    public string PostalCode { get; set; } = string.Empty;


    [ProtoMember(6)]
    public string Country { get; set; } = string.Empty;
}