namespace Booking.Services.Common.Exception;

public class EntityNotFoundException : UseCaseBaseException
{
    public EntityNotFoundException() : base() { }
    public EntityNotFoundException(string message) : base(message)
    {
    }
}
