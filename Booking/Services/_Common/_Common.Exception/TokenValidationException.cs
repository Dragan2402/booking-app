namespace Booking.Services.Common.Exception;

public class TokenValidationException : UseCaseBaseException
{
    public TokenValidationException() : base() { }
    public TokenValidationException(string message) : base(message)
    {
    }
}