﻿using System.Collections.Generic;
using webscanner.Roles.Dto;

namespace webscanner.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
