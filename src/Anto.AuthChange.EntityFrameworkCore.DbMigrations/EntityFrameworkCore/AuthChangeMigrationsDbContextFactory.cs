using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Anto.AuthChange.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AuthChangeMigrationsDbContextFactory : IDesignTimeDbContextFactory<AuthChangeMigrationsDbContext>
    {
        public AuthChangeMigrationsDbContext CreateDbContext(string[] args)
        {
            AuthChangeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AuthChangeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AuthChangeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Anto.AuthChange.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
