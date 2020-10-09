using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metech.SimpleWebApp.Authorization;

namespace Metech.SimpleWebApp
{
    [DependsOn(
        typeof(SimpleWebAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SimpleWebAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SimpleWebAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SimpleWebAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
