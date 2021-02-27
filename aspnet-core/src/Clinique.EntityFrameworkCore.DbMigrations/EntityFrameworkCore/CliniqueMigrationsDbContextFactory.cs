using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Clinique.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CliniqueMigrationsDbContextFactory : IDesignTimeDbContextFactory<CliniqueMigrationsDbContext>
    {
        public CliniqueMigrationsDbContext CreateDbContext(string[] args)
        {
            CliniqueEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CliniqueMigrationsDbContext>()
                .UseSqlite(configuration.GetConnectionString("Default"));

            return new CliniqueMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Clinique.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
