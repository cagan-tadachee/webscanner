using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webscanner.Configuration;

namespace webscanner.Web.Host.Startup
{
    [DependsOn(
       typeof(webscannerWebCoreModule))]
    public class webscannerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public webscannerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(webscannerWebHostModule).GetAssembly());
        }
    }
}
