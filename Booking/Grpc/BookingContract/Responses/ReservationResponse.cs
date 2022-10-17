using ProtoBuf;

namespace Booking.Grpc.BookingContract.Responses;

[ProtoContract]
public class ReservationResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public Guid ClientId { get; set; }

    [ProtoMember(3)]
    public Guid CottageId { get; set; }

    [ProtoMember(4)]
    public string DateFrom { get; set; } = string.Empty;

    [ProtoMember(5)]
    public string DateTo { get; set; } = string.Empty;

    [ProtoMember(6)]
    public string CreatedAt { get; set; } = string.Empty;

    [ProtoMember(7)]
    public string UpdatedAt { get; set; } = string.Empty;
}