using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartLibraries.Authorization;

namespace SmartLibraries
{
    [DependsOn(
        typeof(SmartLibrariesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartLibrariesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartLibrariesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartLibrariesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
