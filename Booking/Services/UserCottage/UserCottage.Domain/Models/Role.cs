using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services.UserCottage.Domain.Models;

public class Role
{
    public Role(Guid id, string name)
    {
        Id = id;
        Name = name;
        Users = new List<User>();
        Permissions = new List<Permission>();
    }

    public Role(string name)
    {
        Name = name;
        Users = new List<User>();
        Permissions = new List<Permission>();
    }

    public Role()
    {
        Name = string.Empty;
        Users = new List<User>();
        Permissions = new List<Permission>();
    }
    public Guid Id { get; set; }
    public List<User> Users { get; set; }
    public List<Permission> Permissions { get; set; }
    public string Name { get; set; }
}
