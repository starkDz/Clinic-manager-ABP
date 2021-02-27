using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Clinique.Data;
using Volo.Abp.DependencyInjection;

namespace Clinique.EntityFrameworkCore
{
    public class EntityFrameworkCoreCliniqueDbSchemaMigrator
        : ICliniqueDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCliniqueDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CliniqueMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CliniqueMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}