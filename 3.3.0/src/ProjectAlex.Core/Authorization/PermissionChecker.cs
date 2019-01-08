using Abp.Authorization;
using ProjectAlex.Authorization.Roles;
using ProjectAlex.Authorization.Users;

namespace ProjectAlex.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
