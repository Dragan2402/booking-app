namespace Booking.Services.Common.Exception;

public abstract class UseCaseBaseException : System.Exception
{
    protected UseCaseBaseException() : base()
    {
    }

    protected UseCaseBaseException(string message) :
        base(message)
    {
    }
}
