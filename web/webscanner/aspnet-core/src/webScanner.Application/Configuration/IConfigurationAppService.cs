using System.Threading.Tasks;
using webScanner.Configuration.Dto;

namespace webScanner.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
