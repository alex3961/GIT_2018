using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectAlex.Configuration.Dto;

namespace ProjectAlex.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}