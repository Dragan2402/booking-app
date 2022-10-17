using ProtoBuf;

namespace Booking.Grpc.BookingContract.Requests;

[ProtoContract]
public class UpdateReservationRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public string DateFrom { get; set; } = string.Empty;

    [ProtoMember(3)]
    public string DateTo { get; set; } = string.Empty;
}