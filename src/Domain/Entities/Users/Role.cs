using Microsoft.AspNetCore.Identity;

namespace MechanicApp.Domain.Entities.Users;
public class Role : IdentityRole
{
    public Role(string roleName) : base(roleName) { }
    public Role() : base() { }
    public ICollection<ApplicationUser>? Users { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
}