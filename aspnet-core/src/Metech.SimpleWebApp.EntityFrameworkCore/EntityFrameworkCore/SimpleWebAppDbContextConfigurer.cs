using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Metech.SimpleWebApp.EntityFrameworkCore
{
    public static class SimpleWebAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SimpleWebAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SimpleWebAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
