using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartLibraries.Authorization.Roles;
using SmartLibraries.Authorization.Users;
using SmartLibraries.Books;
using SmartLibraries.BorrowerTickets;
using SmartLibraries.MultiTenancy;

namespace SmartLibraries.EntityFrameworkCore
{
    public class SmartLibrariesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartLibrariesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowerTicket> BorrowerTickets { get; set; }

        public SmartLibrariesDbContext(DbContextOptions<SmartLibrariesDbContext> options)
            : base(options)
        {
        }
    }
}