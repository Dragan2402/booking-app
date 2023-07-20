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
    }

    public Role(string name)
    {
        Name = name;
        Users = new List<User>();
    }

    public Role()
    {
        Name = string.Empty;
        Users = new List<User>();
    }
    public Guid Id { get; set; }
    public List<User> Users { get; set; }
    public string Name { get; set; }
}
