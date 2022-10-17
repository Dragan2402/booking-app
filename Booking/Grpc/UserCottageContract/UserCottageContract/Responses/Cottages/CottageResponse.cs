using Booking.Grpc._Common.Grpc.Responses;
using ProtoBuf;
namespace Booking.Grpc.UserCottageContract.Responses.Cottages;

[ProtoContract]
public class CottageResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
    [ProtoMember(2)]
    public string Name { get; set; } = string.Empty;
    [ProtoMember(3)]
    public string CreatedAt { get; set; } = string.Empty;

    [ProtoMember(4)]
    public string UpdatedAt { get; set; } = string.Empty;

    [ProtoMember(5)]
    public AddressResponse Address { get; set; } = default!;
}