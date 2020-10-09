using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metech.SimpleWebApp.Configuration;
using Metech.SimpleWebApp.EntityFrameworkCore;
using Metech.SimpleWebApp.Migrator.DependencyInjection;

namespace Metech.SimpleWebApp.Migrator
{
    [DependsOn(typeof(SimpleWebAppEntityFrameworkModule))]
    public class SimpleWebAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SimpleWebAppMigratorModule(SimpleWebAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SimpleWebAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SimpleWebAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleWebAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
