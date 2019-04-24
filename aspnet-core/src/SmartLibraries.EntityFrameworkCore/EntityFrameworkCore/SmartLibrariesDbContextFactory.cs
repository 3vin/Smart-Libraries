using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SmartLibraries.Configuration;
using SmartLibraries.Web;

namespace SmartLibraries.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SmartLibrariesDbContextFactory : IDesignTimeDbContextFactory<SmartLibrariesDbContext>
    {
        public SmartLibrariesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SmartLibrariesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SmartLibrariesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SmartLibrariesConsts.ConnectionStringName));

            return new SmartLibrariesDbContext(builder.Options);
        }
    }
}
