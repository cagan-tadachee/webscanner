using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using webScanner.Controllers;

namespace webScanner.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : webScannerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
