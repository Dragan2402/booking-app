using Booking.Grpc._Common.Grpc.Requests;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Users;

[ProtoContract]
public class CreateUserRequest
{
    [ProtoMember(1)]
    public string FirstName { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string LastName { get; set; } = string.Empty;

    [ProtoMember(3)]
    public Guid IdentityId { get; set; }

    [ProtoMember(4)]
    public string Role { get; set; } = string.Empty;

    [ProtoMember(5)]
    public AddressRequest Address = default!;
}