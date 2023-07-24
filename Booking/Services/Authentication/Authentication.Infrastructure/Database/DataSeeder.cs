

using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Authentication.Infrastructure.Database;
using Booking.Services.Common.Data;
using Microsoft.EntityFrameworkCore;

public class DataSeeder
{
    private readonly AuthenticationContext _dbContext;

    public DataSeeder(AuthenticationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        var userPermissions = new List<Permission>();
        var ownerPermissions = new List<Permission>();
        var adminPermissions = new List<Permission>();

        foreach (var permissionEnum in (PermissionValue[])Enum.GetValues(typeof(PermissionValue)))
        {
            var permission = new Permission
            {
                PermissionValue = permissionEnum
            };

            if (!_dbContext.Permissions.Any(p => p.Id == permission.Id))
            {
                _dbContext.Permissions.Add(permission);
            }

            adminPermissions.Add(permission);

            switch (permissionEnum)
            {
                case PermissionValue.ReadCottages:
                case PermissionValue.AddCottage:
                case PermissionValue.UpdateCottage:
                case PermissionValue.DeleteCottage:
                case PermissionValue.ReadUsers:
                case PermissionValue.AddUser:
                case PermissionValue.DeleteUser:
                case PermissionValue.UpdateUser:
                    ownerPermissions.Add(permission);
                    break;
            }

            switch (permissionEnum)
            {
                case PermissionValue.ReadUsers:
                case PermissionValue.AddUser:
                case PermissionValue.DeleteUser:
                case PermissionValue.UpdateUser:
                    userPermissions.Add(permission);
                    break;
            }
        }

        _dbContext.SaveChanges();

        var adminRole = _dbContext.Roles.Include(x => x.Permissions).SingleOrDefault(x => x.Name == GeneralRoles.AdminRole);

        if (adminRole == null)
        {
            adminRole = new Role
            {
                Id = new Guid("162613b2-aa55-498c-9819-c01caaa4ecca"),
                Name = GeneralRoles.AdminRole
            };

            _dbContext.Roles.Add(adminRole);
            _dbContext.SaveChanges();
        }

        var ownerRole = _dbContext.Roles.Include(x => x.Permissions).SingleOrDefault(x => x.Name == GeneralRoles.OwnerRole);
        if (ownerRole == null)
        {
            ownerRole = new Role
            {
                Id = new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"),
                Name = GeneralRoles.OwnerRole
            };

            _dbContext.Roles.Add(ownerRole);
            _dbContext.SaveChanges();
        }

        var userRole = _dbContext.Roles.Include(x => x.Permissions).SingleOrDefault(x => x.Name == GeneralRoles.ClientRole);
        if (userRole == null)
        {
            userRole = new Role
            {
                Id = new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"),
                Name = GeneralRoles.ClientRole
            };

            _dbContext.Roles.Add(userRole);
            _dbContext.SaveChanges();
        }

        AddPermissionsToRole(adminRole, adminPermissions);
        AddPermissionsToRole(ownerRole, ownerPermissions);
        AddPermissionsToRole(userRole, userPermissions);


        _dbContext.SaveChanges();
    }

    private void AddPermissionsToRole(Role role, IEnumerable<Permission> permissions)
    {
        foreach (var permission in permissions)
        {
            if (role.Permissions.Any(x => x.Id == permission.Id))
            {
                continue;
            }

            var permissionData = _dbContext.Permissions.First(x => x.PermissionValue == permission.PermissionValue);
            permissionData.Roles.Add(role);
            role.Permissions.Add(permissionData);
        }

        _dbContext.Update(role);
    }
}
