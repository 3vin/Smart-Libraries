using System.Threading.Tasks;
using Abp.Application.Services;
using SmartLibraries.Sessions.Dto;

namespace SmartLibraries.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
