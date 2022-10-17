using Booking.Grpc._Common.Grpc.Requests;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Cottages;
[ProtoContract]
public class CreateCottageRequest
{
    [ProtoMember(1)]
    public Guid OwnerId { get; set; }
    [ProtoMember(2)]
    public string Name { get; set; } = string.Empty;
    [ProtoMember(3)]
    public AddressRequest Address = default!;
}