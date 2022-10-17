using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Responses;

[ProtoContract]
public class CreateIdentityResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
}