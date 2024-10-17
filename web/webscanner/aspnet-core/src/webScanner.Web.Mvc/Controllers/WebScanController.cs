using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using webScanner.Authorization;
using webScanner.Controllers;
using webScanner.WebScan;

namespace webScanner.Web.Controllers
{

    [AbpMvcAuthorize(PermissionNames.Pages_WebScan)]
    public class WebScanController : webScannerControllerBase
    {
        private readonly IWebScanservice _webScanService;
        
        public WebScanController(IWebScanService webScanService)
        {
            _webScanService = webScanService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
