using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SchoolAwesome.MultiTenancy.Dto;

namespace SchoolAwesome.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
