using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Responses.Users;

[ProtoContract]
public class DeleteUserResponse
{
    [ProtoMember(1)]
    public Guid IdentityId { get; set; }
}