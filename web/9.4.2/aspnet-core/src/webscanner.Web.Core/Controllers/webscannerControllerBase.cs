using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace webscanner.Controllers
{
    public abstract class webscannerControllerBase: AbpController
    {
        protected webscannerControllerBase()
        {
            LocalizationSourceName = webscannerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
