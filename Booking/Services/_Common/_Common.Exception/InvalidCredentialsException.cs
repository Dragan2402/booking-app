namespace Booking.Services.Common.Exception;

public class InvalidCredentialsException : UseCaseBaseException
{
    public InvalidCredentialsException() : base() { }
    public InvalidCredentialsException(string message) : base(message)
    {
    }
}