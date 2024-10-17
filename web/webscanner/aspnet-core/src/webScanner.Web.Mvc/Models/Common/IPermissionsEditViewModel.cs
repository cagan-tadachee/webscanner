using System.Collections.Generic;
using webScanner.Roles.Dto;

namespace webScanner.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}