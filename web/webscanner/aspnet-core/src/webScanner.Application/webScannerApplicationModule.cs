﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webScanner.Authorization;

namespace webScanner
{
    [DependsOn(
        typeof(webScannerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class webScannerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<webScannerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(webScannerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
