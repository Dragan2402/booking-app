using Booking.Services.Common.Exception;

public class EmailNotUniqueException : UseCaseBaseException
{
    public EmailNotUniqueException() : base() { }
    public EmailNotUniqueException(string message) : base(message)
    {
    }
}