using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SchoolAwesome.Controllers
{
    public abstract class SchoolAwesomeControllerBase: AbpController
    {
        protected SchoolAwesomeControllerBase()
        {
            LocalizationSourceName = SchoolAwesomeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
