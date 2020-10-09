using Abp.Application.Services.Dto;

namespace Metech.SimpleWebApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

