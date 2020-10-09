using Abp.Authorization;
using Metech.SimpleWebApp.Authorization.Roles;
using Metech.SimpleWebApp.Authorization.Users;

namespace Metech.SimpleWebApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
