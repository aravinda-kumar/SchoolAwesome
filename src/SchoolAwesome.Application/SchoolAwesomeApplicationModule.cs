using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolAwesome.Authorization;

namespace SchoolAwesome
{
    [DependsOn(
        typeof(SchoolAwesomeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchoolAwesomeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchoolAwesomeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchoolAwesomeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
