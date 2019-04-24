using Abp.Authorization;
using SmartLibraries.Authorization.Roles;
using SmartLibraries.Authorization.Users;

namespace SmartLibraries.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
