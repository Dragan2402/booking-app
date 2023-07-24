namespace Booking.Services.Authentication.Domain.Models;

public class Role
{
    public Role(Guid id, string name)
    {
        Id = id;
        Name = name;
        Identities = new List<Identity>();
        Permissions = new List<Permission>();
    }

    public Role(string name)
    {
        Name = name;
        Identities = new List<Identity>();
        Permissions = new List<Permission>();
    }

    public Role()
    {
        Name = string.Empty;
        Identities = new List<Identity>();
        Permissions = new List<Permission>();
    }
    public Guid Id { get; set; }
    public List<Identity> Identities { get; set; }
    public List<Permission> Permissions { get; set; }
    public string Name { get; set; }
}
