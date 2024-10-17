using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webscanner.EntityFrameworkCore;
using webscanner.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace webscanner.Web.Tests
{
    [DependsOn(
        typeof(webscannerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class webscannerWebTestModule : AbpModule
    {
        public webscannerWebTestModule(webscannerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(webscannerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(webscannerWebMvcModule).Assembly);
        }
    }
}