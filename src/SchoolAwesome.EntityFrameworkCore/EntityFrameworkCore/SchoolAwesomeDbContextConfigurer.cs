using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SchoolAwesome.EntityFrameworkCore
{
    public static class SchoolAwesomeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolAwesomeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchoolAwesomeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
