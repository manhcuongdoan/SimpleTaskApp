using System.Threading.Tasks;
using Abp.Application.Services;
using Metech.SimpleWebApp.Authorization.Accounts.Dto;

namespace Metech.SimpleWebApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
