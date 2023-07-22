using Booking.Services.Common.Domain;

namespace Booking.Services.Booking.Domain;

public class Offer : IAuditable, ISoftDeletable
{
    public Offer(Guid id, DateTimeOffset dateFrom, DateTimeOffset dateTo, Guid cottageId, double totalPrice)
    {
        Id = id;
        DateFrom = dateFrom;
        DateTo = dateTo;
        CottageId = cottageId;
        TotalPrice = totalPrice;
    }
    public Offer()
    {
        this.DateFrom = DateTimeOffset.Now;
        this.DateTo = DateTimeOffset.MaxValue;
    }

    public Guid Id { get; set; }
    public DateTimeOffset DateFrom { get; set; }
    public DateTimeOffset DateTo { get; set; }
    public Guid CottageId { get; set; }
    public double TotalPrice { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
