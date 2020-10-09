using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Metech.SimpleWebApp.Roles.Dto;
using Metech.SimpleWebApp.Users.Dto;

namespace Metech.SimpleWebApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
