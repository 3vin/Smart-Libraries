using System.Threading.Tasks;
using SmartLibraries.Configuration.Dto;

namespace SmartLibraries.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
