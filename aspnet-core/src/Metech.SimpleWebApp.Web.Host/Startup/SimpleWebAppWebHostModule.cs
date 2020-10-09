using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metech.SimpleWebApp.Configuration;

namespace Metech.SimpleWebApp.Web.Host.Startup
{
    [DependsOn(
       typeof(SimpleWebAppWebCoreModule))]
    public class SimpleWebAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SimpleWebAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleWebAppWebHostModule).GetAssembly());
        }
    }
}
