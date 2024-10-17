using Abp.AspNetCore.Mvc.ViewComponents;

namespace webScanner.Web.Views
{
    public abstract class webScannerViewComponent : AbpViewComponent
    {
        protected webScannerViewComponent()
        {
            LocalizationSourceName = webScannerConsts.LocalizationSourceName;
        }
    }
}
