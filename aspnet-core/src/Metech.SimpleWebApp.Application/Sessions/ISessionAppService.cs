using System.Threading.Tasks;
using Abp.Application.Services;
using Metech.SimpleWebApp.Sessions.Dto;

namespace Metech.SimpleWebApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
