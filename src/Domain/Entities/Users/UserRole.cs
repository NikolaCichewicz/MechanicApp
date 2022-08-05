using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MechanicApp.Domain.Entities.Users;

public class UserRole : IdentityUserRole<string>
{
    public UserRole() : base() { }
    public override string UserId { get; set; }

    public ApplicationUser User { get; set; }
    public override string RoleId { get; set; }

    public Role Role { get; set; }
}