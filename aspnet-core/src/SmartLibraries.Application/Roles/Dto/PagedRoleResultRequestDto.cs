using Abp.Application.Services.Dto;

namespace SmartLibraries.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

