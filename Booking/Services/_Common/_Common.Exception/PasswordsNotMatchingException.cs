namespace Booking.Services.Common.Exception;

public class PasswordsNotMatchingException : UseCaseBaseException
{
    public PasswordsNotMatchingException() : base() { }
    public PasswordsNotMatchingException(string message) : base(message)
    {
    }
}