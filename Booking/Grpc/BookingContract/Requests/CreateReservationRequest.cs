using ProtoBuf;

namespace Booking.Grpc.BookingContract.Requests;

[ProtoContract]
public class CreateReservationRequest
{
    [ProtoMember(1)]
    public Guid ClientId {  get; set; }

    [ProtoMember(2)]
    public Guid CottageId { get; set; }

    [ProtoMember(3)]
    public string DateFrom { get; set; } = string.Empty;

    [ProtoMember(4)]
    public string DateTo { get; set; } = string.Empty;
}