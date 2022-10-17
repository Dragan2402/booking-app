using ProtoBuf;

namespace Booking.Grpc.AuthenticationContract.Requests;

[ProtoContract]
public class CreateIdentityRequest
{
    [ProtoMember(1)]
    public string Email { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string Password { get; set; } = string.Empty;

    [ProtoMember(3)]
    public string ConfirmPassword { get; set; } = string.Empty;
}