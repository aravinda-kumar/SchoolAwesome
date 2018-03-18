using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace SchoolAwesome.Web.Views
{
    public abstract class SchoolAwesomeRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SchoolAwesomeRazorPage()
        {
            LocalizationSourceName = SchoolAwesomeConsts.LocalizationSourceName;
        }
    }
}
