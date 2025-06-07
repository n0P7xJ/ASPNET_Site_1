using Microsoft.AspNetCore.Identity;

namespace ASPNET_Site_1.Data.Entities.Idenity;

public class RoleEntity : IdentityRole<int>
{
    public ICollection<UserRoleEntity>? UserRoles { get; set; }
}
