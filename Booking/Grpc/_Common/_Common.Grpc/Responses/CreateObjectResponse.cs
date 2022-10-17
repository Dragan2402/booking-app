using ProtoBuf;

namespace Booking.Grpc._Common.Grpc.Responses;


[ProtoContract]
public class CreateObjectResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
}