using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Users;

[ProtoContract]
public class UpdateUserRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public UpdateUserUserRequest UserRequest { get; set; } = default!;
}