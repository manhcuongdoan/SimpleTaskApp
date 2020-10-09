using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Metech.SimpleWebApp.Configuration.Dto;

namespace Metech.SimpleWebApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SimpleWebAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
