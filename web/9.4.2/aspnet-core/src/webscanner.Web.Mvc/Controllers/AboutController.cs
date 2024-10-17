using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using webscanner.Controllers;

namespace webscanner.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : webscannerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
