using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Metech.SimpleWebApp.Roles.Dto;

namespace Metech.SimpleWebApp.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
    }
}
