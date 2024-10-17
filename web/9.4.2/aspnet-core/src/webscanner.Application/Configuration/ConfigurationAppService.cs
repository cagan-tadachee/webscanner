using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using webscanner.Configuration.Dto;

namespace webscanner.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : webscannerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
