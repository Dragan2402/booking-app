using Booking.Services.Common.Domain;
namespace Booking.Services.Booking.Domain;

public class Reservation : IAuditable, ISoftDeletable
{
    public Reservation(Guid id, DateTimeOffset dateFrom, DateTimeOffset dateTo, Guid cottageId, Guid clientId)
    {
        Id = id;
        DateFrom = dateFrom;
        DateTo = dateTo;
        CottageId = cottageId;
        ClientId = clientId;
    }
    public Reservation()
    {
        this.DateFrom = DateTimeOffset.Now;
        this.DateTo = DateTimeOffset.MaxValue;
    }

    public Guid Id { get; set; }
    public DateTimeOffset DateFrom { get; set; }
    public DateTimeOffset DateTo { get; set; }
    public Guid CottageId { get; set; }
    public Guid ClientId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
