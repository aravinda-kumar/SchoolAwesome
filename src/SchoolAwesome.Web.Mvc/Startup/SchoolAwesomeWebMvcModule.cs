using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolAwesome.Configuration;

namespace SchoolAwesome.Web.Startup
{
    [DependsOn(typeof(SchoolAwesomeWebCoreModule))]
    public class SchoolAwesomeWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolAwesomeWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SchoolAwesomeNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolAwesomeWebMvcModule).GetAssembly());
        }
    }
}
