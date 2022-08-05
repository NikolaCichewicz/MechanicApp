using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicApp.Domain.Entities.Users;

public class UserSettings : AuditableEntity, IDbModel<int>
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public NameFormat NameFormat { get; set; }
    public DateFormat DateFormat { get; set; }
    public int Pagination { get; set; }
    public bool SaveTableViews { get; set; }
}
