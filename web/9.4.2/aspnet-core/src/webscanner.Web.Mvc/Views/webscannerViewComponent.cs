using Abp.AspNetCore.Mvc.ViewComponents;

namespace webscanner.Web.Views
{
    public abstract class webscannerViewComponent : AbpViewComponent
    {
        protected webscannerViewComponent()
        {
            LocalizationSourceName = webscannerConsts.LocalizationSourceName;
        }
    }
}
