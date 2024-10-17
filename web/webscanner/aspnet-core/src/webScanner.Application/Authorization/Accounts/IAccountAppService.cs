using System.Threading.Tasks;
using Abp.Application.Services;
using webScanner.Authorization.Accounts.Dto;

namespace webScanner.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
