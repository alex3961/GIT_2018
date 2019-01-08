using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ProjectAlex.MultiTenancy.Dto;

namespace ProjectAlex.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
