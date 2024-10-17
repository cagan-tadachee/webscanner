using System.Collections.Generic;
using webScanner.Roles.Dto;

namespace webScanner.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
