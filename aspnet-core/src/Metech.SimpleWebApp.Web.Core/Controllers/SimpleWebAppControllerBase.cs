using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Metech.SimpleWebApp.Controllers
{
    public abstract class SimpleWebAppControllerBase: AbpController
    {
        protected SimpleWebAppControllerBase()
        {
            LocalizationSourceName = SimpleWebAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
