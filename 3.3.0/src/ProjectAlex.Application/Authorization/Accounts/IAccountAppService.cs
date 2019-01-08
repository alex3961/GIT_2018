using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectAlex.Authorization.Accounts.Dto;

namespace ProjectAlex.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
