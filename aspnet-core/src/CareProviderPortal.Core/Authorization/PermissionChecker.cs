using Abp.Authorization;
using CareProviderPortal.Authorization.Roles;
using CareProviderPortal.Authorization.Users;

namespace CareProviderPortal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
