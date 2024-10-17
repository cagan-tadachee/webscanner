using Abp.Authorization;
using webscanner.Authorization.Roles;
using webscanner.Authorization.Users;

namespace webscanner.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
