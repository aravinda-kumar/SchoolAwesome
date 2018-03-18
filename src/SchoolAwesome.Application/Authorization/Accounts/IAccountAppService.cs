using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolAwesome.Authorization.Accounts.Dto;

namespace SchoolAwesome.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
