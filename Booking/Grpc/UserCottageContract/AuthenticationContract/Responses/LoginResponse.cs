using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Responses;

[ProtoContract]
public class LoginResponse
{
    [ProtoMember(1)]
    public string Identity { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string Refresh { get; set; } = string.Empty;

    [ProtoMember(3)]
    public int ExpiresIn { get; set; }
}
