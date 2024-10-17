using Abp.Authorization;
using webScanner.Authorization.Roles;
using webScanner.Authorization.Users;

namespace webScanner.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
