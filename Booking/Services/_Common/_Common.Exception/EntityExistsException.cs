namespace Booking.Services.Common.Exception;

public class EntityExistsException : UseCaseBaseException
{
    public EntityExistsException() : base() { }
    public EntityExistsException(string message) : base(message)
    {
    }
}