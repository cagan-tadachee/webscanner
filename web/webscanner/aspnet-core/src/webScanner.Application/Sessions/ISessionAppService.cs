using System.Threading.Tasks;
using Abp.Application.Services;
using webScanner.Sessions.Dto;

namespace webScanner.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
