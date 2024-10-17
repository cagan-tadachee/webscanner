using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace webScanner.EntityFrameworkCore
{
    public static class webScannerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<webScannerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<webScannerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
