using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using webscanner.Authorization.Roles;
using webscanner.Authorization.Users;
using webscanner.MultiTenancy;

namespace webscanner.EntityFrameworkCore
{
    public class webscannerDbContext : AbpZeroDbContext<Tenant, Role, User, webscannerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public webscannerDbContext(DbContextOptions<webscannerDbContext> options)
            : base(options)
        {
        }
    }
}
