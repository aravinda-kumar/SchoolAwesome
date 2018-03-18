using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SchoolAwesome.Roles.Dto;
using SchoolAwesome.Users.Dto;

namespace SchoolAwesome.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
