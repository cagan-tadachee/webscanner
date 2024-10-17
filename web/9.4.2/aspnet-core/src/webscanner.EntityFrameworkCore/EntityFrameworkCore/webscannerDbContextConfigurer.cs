using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace webscanner.EntityFrameworkCore
{
    public static class webscannerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<webscannerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<webscannerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
