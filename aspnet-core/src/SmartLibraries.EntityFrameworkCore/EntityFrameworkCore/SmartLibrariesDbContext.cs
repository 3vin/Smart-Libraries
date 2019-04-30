using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartLibraries.Authorization.Roles;
using SmartLibraries.Authorization.Users;
using SmartLibraries.MultiTenancy;
using SmartLibraries.BorrowerTickets;
using SmartLibraries.Books;

namespace SmartLibraries.EntityFrameworkCore
{
    public class SmartLibrariesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartLibrariesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Book> Books;
        public DbSet<BorrowerTicket> BorrowerTickets;
        
        public SmartLibrariesDbContext(DbContextOptions<SmartLibrariesDbContext> options)
            : base(options)
        {
        }
    }
}
