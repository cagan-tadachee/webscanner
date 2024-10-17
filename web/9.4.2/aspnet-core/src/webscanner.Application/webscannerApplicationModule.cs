using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webscanner.Authorization;

namespace webscanner
{
    [DependsOn(
        typeof(webscannerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class webscannerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<webscannerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(webscannerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
