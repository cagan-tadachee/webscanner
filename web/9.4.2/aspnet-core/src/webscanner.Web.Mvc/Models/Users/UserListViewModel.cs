using System.Collections.Generic;
using webscanner.Roles.Dto;

namespace webscanner.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
