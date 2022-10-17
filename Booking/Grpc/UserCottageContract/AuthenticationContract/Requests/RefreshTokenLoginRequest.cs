using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Requests;

[ProtoContract]
public class RefreshTokenLoginRequest
{
    [ProtoMember(1)]
    public string RefreshToken { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string Origin { get; set; } = string.Empty;
}
