using Booking.Grpc._Common.Grpc.Responses;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Responses.Users;

[ProtoContract]
public class UserResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public string FirstName { get; set; } = string.Empty;

    [ProtoMember(3)]
    public string LastName { get; set; } = string.Empty;

    [ProtoMember(4)]
    public Guid IdentityId { get; set; }

    [ProtoMember(5)]
    public string Role { get; set; } = string.Empty;

    [ProtoMember(6)]
    public string CreatedAt { get; set; } = string.Empty;

    [ProtoMember(7)]
    public string UpdatedAt { get; set; } = string.Empty;

    [ProtoMember(8)]
    public AddressResponse Address { get; set; } = default!;
}