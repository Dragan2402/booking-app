using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Requests;

[ProtoContract]
public class ValidateAccessTokenRequest
{
    [ProtoMember(1)]
    public string Token { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string Origin { get; set; } = string.Empty;
}
