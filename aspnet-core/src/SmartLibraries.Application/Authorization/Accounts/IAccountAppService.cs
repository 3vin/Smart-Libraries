using System.Threading.Tasks;
using Abp.Application.Services;
using SmartLibraries.Authorization.Accounts.Dto;

namespace SmartLibraries.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
