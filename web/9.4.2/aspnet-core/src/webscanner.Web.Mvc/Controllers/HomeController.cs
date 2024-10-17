using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using webscanner.Controllers;

namespace webscanner.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : webscannerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
