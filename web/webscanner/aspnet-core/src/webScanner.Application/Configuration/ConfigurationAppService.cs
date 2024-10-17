using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using webScanner.Configuration.Dto;

namespace webScanner.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : webScannerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
