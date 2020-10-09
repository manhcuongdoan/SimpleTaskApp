using Abp.Application.Services;
using Metech.SimpleWebApp.MultiTenancy.Dto;

namespace Metech.SimpleWebApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

