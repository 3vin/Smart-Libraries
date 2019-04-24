using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartLibraries.Configuration;

namespace SmartLibraries.Web.Host.Startup
{
    [DependsOn(
       typeof(SmartLibrariesWebCoreModule))]
    public class SmartLibrariesWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SmartLibrariesWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartLibrariesWebHostModule).GetAssembly());
        }
    }
}
