using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolAwesome.Configuration;
using SchoolAwesome.EntityFrameworkCore;
using SchoolAwesome.Migrator.DependencyInjection;

namespace SchoolAwesome.Migrator
{
    [DependsOn(typeof(SchoolAwesomeEntityFrameworkModule))]
    public class SchoolAwesomeMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolAwesomeMigratorModule(SchoolAwesomeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SchoolAwesomeMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SchoolAwesomeConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolAwesomeMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
