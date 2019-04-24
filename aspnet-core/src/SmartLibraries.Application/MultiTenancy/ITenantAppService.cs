using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartLibraries.MultiTenancy.Dto;

namespace SmartLibraries.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

