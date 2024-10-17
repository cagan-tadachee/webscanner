using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace webscanner.Web.Views
{
    public abstract class webscannerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected webscannerRazorPage()
        {
            LocalizationSourceName = webscannerConsts.LocalizationSourceName;
        }
    }
}
