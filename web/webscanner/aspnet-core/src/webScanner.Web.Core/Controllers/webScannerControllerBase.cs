using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace webScanner.Controllers
{
    public abstract class webScannerControllerBase: AbpController
    {
        protected webScannerControllerBase()
        {
            LocalizationSourceName = webScannerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
