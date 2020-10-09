using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Metech.SimpleWebApp.Authorization.Roles;
using Metech.SimpleWebApp.Authorization.Users;
using Metech.SimpleWebApp.MultiTenancy;

namespace Metech.SimpleWebApp.EntityFrameworkCore
{
    public class SimpleWebAppDbContext : AbpZeroDbContext<Tenant, Role, User, SimpleWebAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SimpleWebAppDbContext(DbContextOptions<SimpleWebAppDbContext> options)
            : base(options)
        {
        }
    }
}
