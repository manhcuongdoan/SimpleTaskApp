using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metech.SimpleWebApp.EntityFrameworkCore;
using Metech.SimpleWebApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Metech.SimpleWebApp.Web.Tests
{
    [DependsOn(
        typeof(SimpleWebAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SimpleWebAppWebTestModule : AbpModule
    {
        public SimpleWebAppWebTestModule(SimpleWebAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleWebAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SimpleWebAppWebMvcModule).Assembly);
        }
    }
}