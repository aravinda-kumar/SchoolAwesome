using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolAwesome.Configuration;

namespace SchoolAwesome.Web.Host.Startup
{
    [DependsOn(
       typeof(SchoolAwesomeWebCoreModule))]
    public class SchoolAwesomeWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolAwesomeWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolAwesomeWebHostModule).GetAssembly());
        }
    }
}
