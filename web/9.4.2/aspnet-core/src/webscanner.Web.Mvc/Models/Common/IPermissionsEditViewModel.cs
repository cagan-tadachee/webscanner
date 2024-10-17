using System.Collections.Generic;
using webscanner.Roles.Dto;

namespace webscanner.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}