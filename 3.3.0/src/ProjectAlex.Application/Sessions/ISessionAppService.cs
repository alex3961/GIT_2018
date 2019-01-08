using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectAlex.Sessions.Dto;

namespace ProjectAlex.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
