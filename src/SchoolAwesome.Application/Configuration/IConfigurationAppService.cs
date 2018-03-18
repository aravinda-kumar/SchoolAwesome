using System.Threading.Tasks;
using SchoolAwesome.Configuration.Dto;

namespace SchoolAwesome.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
