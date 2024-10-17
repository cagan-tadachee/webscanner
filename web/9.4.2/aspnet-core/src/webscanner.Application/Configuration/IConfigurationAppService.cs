using System.Threading.Tasks;
using webscanner.Configuration.Dto;

namespace webscanner.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
