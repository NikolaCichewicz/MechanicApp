using Microsoft.AspNetCore.Identity;

namespace MechanicApp.Domain.Entities.Users;

public class ApplicationUser : IdentityUser, IAuditableEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public UserSettings UserSettings { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }

    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
}
