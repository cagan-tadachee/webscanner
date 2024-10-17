using Abp.Application.Services;
using webscanner.MultiTenancy.Dto;

namespace webscanner.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

