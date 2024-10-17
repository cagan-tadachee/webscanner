using System.Threading.Tasks;
using Abp.Application.Services;
using webscanner.Authorization.Accounts.Dto;

namespace webscanner.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
