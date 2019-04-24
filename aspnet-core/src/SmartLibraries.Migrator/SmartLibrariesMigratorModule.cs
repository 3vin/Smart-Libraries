using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartLibraries.Configuration;
using SmartLibraries.EntityFrameworkCore;
using SmartLibraries.Migrator.DependencyInjection;

namespace SmartLibraries.Migrator
{
    [DependsOn(typeof(SmartLibrariesEntityFrameworkModule))]
    public class SmartLibrariesMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SmartLibrariesMigratorModule(SmartLibrariesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SmartLibrariesMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SmartLibrariesConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(SmartLibrariesMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
