using System.Threading.Tasks;
using Metech.SimpleWebApp.Configuration.Dto;

namespace Metech.SimpleWebApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
