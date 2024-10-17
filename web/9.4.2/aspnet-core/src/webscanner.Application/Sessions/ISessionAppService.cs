using System.Threading.Tasks;
using Abp.Application.Services;
using webscanner.Sessions.Dto;

namespace webscanner.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
