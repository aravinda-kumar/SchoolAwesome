using Abp.Authorization;
using SchoolAwesome.Authorization.Roles;
using SchoolAwesome.Authorization.Users;

namespace SchoolAwesome.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
