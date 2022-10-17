using ProtoBuf;

namespace Booking.Grpc._Common.Grpc.Requests;

[ProtoContract]
public class DeleteObjectRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
}