using Abp.Application.Services;
using webScanner.MultiTenancy.Dto;

namespace webScanner.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

