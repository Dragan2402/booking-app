using Booking.Services.Common.Data;

namespace Booking.Services.UserCottage.Domain.Models;

public class Permission
{
    public Permission(Guid id, PermissionValue permissionValue)
    {
        Id = id;
        PermissionValue = permissionValue;
        Roles = new List<Role>();
    }

    public Permission(PermissionValue permissionValue)
    {
        PermissionValue = permissionValue;
        Roles = new List<Role>();
    }

    public Permission()
    {
        Roles = new List<Role>();
    }

    public Guid Id { get; set; }
    public PermissionValue PermissionValue { get; set; }
    public List<Role> Roles { get; set; }
}
