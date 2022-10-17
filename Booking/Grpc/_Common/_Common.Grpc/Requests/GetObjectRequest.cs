using ProtoBuf;

namespace Booking.Grpc._Common.Grpc.Requests;

[ProtoContract]
public class GetObjectRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
}