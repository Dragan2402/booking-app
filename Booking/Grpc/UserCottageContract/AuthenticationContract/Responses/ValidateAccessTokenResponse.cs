using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Responses;

[ProtoContract]
public class ValidateAccessTokenResponse
{
    [ProtoMember(1)]
    public Guid IdentityId { get; set; }
}