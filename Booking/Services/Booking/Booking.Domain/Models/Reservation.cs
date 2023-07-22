using Booking.Services.Common.Domain;
namespace Booking.Services.Booking.Domain;

public class Reservation : IAuditable, ISoftDeletable
{
    public Reservation(
        Guid id, 
        DateTimeOffset dateFrom, 
        DateTimeOffset dateTo,
        Guid cottageId,
        Guid clientId, 
        double totalPrice, 
        bool withDiscount,
        double fee)
    {
        Id = id;
        DateFrom = dateFrom;
        DateTo = dateTo;
        CottageId = cottageId;
        ClientId = clientId;
        TotalPrice = totalPrice;
        WithDiscount = withDiscount;
        Fee = fee;
        SpecialRequest = string.Empty;
    }
    public Reservation()
    {
        DateFrom = DateTimeOffset.Now;
        DateTo = DateTimeOffset.MaxValue;
        SpecialRequest = string.Empty;
    }

    public Guid Id { get; set; }
    public DateTimeOffset DateFrom { get; set; }
    public DateTimeOffset DateTo { get; set; }
    public Guid CottageId { get; set; }
    public Guid ClientId { get; set; }
    public double TotalPrice { get; set; }
    public bool WithDiscount { get; set; }
    public double Fee { get; set; }
    public string SpecialRequest { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
