using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Metech.SimpleWebApp.Configuration;
using Metech.SimpleWebApp.Web;

namespace Metech.SimpleWebApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SimpleWebAppDbContextFactory : IDesignTimeDbContextFactory<SimpleWebAppDbContext>
    {
        public SimpleWebAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SimpleWebAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SimpleWebAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SimpleWebAppConsts.ConnectionStringName));

            return new SimpleWebAppDbContext(builder.Options);
        }
    }
}
