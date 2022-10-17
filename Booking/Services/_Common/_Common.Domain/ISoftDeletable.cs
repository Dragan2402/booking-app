namespace Booking.Services.Common.Domain;

public interface ISoftDeletable
{
    public DateTimeOffset? DeletedAt { get; set; }
}
