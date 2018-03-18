using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SchoolAwesome.Configuration;
using SchoolAwesome.Web;

namespace SchoolAwesome.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SchoolAwesomeDbContextFactory : IDesignTimeDbContextFactory<SchoolAwesomeDbContext>
    {
        public SchoolAwesomeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolAwesomeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SchoolAwesomeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SchoolAwesomeConsts.ConnectionStringName));

            return new SchoolAwesomeDbContext(builder.Options);
        }
    }
}
