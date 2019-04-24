using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartLibraries.EntityFrameworkCore
{
    public static class SmartLibrariesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartLibrariesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartLibrariesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
