using Abp.MultiTenancy;
using Metech.SimpleWebApp.Authorization.Users;

namespace Metech.SimpleWebApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
