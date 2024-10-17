using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace webScanner.Web.Views
{
    public abstract class webScannerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected webScannerRazorPage()
        {
            LocalizationSourceName = webScannerConsts.LocalizationSourceName;
        }
    }
}
