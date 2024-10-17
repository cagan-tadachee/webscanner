using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webScanner.Configuration;

namespace webScanner.Web.Host.Startup
{
    [DependsOn(
       typeof(webScannerWebCoreModule))]
    public class webScannerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public webScannerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(webScannerWebHostModule).GetAssembly());
        }
    }
}
