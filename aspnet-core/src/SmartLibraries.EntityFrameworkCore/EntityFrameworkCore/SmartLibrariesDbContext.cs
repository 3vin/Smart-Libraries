using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartLibraries.Authorization.Roles;
using SmartLibraries.Authorization.Users;
using SmartLibraries.MultiTenancy;

namespace SmartLibraries.EntityFrameworkCore
{
    public class SmartLibrariesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartLibrariesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SmartLibrariesDbContext(DbContextOptions<SmartLibrariesDbContext> options)
            : base(options)
        {
        }
    }
}
