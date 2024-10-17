using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using webScanner.Authorization.Roles;
using webScanner.Authorization.Users;
using webScanner.MultiTenancy;

namespace webScanner.EntityFrameworkCore
{
    public class webScannerDbContext : AbpZeroDbContext<Tenant, Role, User, webScannerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public webScannerDbContext(DbContextOptions<webScannerDbContext> options)
            : base(options)
        {
        }
    }
}
