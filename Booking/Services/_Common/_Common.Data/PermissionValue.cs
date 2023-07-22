using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services.Common.Data;

public enum PermissionValue
{
    ReadCottages = 1,
    AddCottage = 2,
    UpdateCottage = 3,
    DeleteCottage = 4,

    ReadUsers = 11,
    AddUser = 12,
    UpdateUser = 13,
    DeleteUser = 14,
}
