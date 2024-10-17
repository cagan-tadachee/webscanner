using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webScanner.EntityFrameworkCore;
using webScanner.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace webScanner.Web.Tests
{
    [DependsOn(
        typeof(webScannerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class webScannerWebTestModule : AbpModule
    {
        public webScannerWebTestModule(webScannerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(webScannerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(webScannerWebMvcModule).Assembly);
        }
    }
}