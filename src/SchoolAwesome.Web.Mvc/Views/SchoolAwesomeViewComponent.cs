using Abp.AspNetCore.Mvc.ViewComponents;

namespace SchoolAwesome.Web.Views
{
    public abstract class SchoolAwesomeViewComponent : AbpViewComponent
    {
        protected SchoolAwesomeViewComponent()
        {
            LocalizationSourceName = SchoolAwesomeConsts.LocalizationSourceName;
        }
    }
}
