using System.Collections.Generic;
using SchoolAwesome.Roles.Dto;
using SchoolAwesome.Users.Dto;

namespace SchoolAwesome.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
