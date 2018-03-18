using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolAwesome.Sessions.Dto;

namespace SchoolAwesome.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
