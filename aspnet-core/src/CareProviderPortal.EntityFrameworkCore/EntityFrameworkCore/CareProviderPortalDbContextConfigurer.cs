using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CareProviderPortal.EntityFrameworkCore
{
    public static class CareProviderPortalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CareProviderPortalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CareProviderPortalDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}