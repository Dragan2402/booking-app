using Booking.Grpc._Common.Grpc.Requests;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Users;

[ProtoContract]
public class UpdateUserUserRequest
{
    [ProtoMember(1)]
    public string FirstName { get; set; } = string.Empty;

    [ProtoMember(2)]
    public string LastName { get; set; } = string.Empty;

    [ProtoMember(3)]
    public AddressRequest Address { get; set; } = default!;
}