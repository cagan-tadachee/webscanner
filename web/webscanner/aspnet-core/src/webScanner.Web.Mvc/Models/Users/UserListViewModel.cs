using System.Collections.Generic;
using webScanner.Roles.Dto;

namespace webScanner.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
