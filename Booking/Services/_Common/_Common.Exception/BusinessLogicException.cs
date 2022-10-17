namespace Booking.Services.Common.Exception;

public class BusinessLogicException : UseCaseBaseException
{
    public BusinessLogicException() : base() { }
    public BusinessLogicException(string message) : base(message)
    {
    }
}