using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Users;

[ProtoContract]
public class GetUserRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
}