using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProjectAlex.Configuration.Dto;

namespace ProjectAlex.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjectAlexAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
