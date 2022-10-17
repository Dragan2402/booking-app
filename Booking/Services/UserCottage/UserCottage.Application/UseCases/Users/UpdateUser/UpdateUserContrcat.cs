namespace Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;

public class UpdateUserContract
{
    public Guid Id { get; set; }

    public UserContract User { get; set; } = default!;
}