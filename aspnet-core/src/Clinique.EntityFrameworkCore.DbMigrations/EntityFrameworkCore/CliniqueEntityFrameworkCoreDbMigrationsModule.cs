using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Clinique.EntityFrameworkCore
{
    [DependsOn(
        typeof(CliniqueEntityFrameworkCoreModule)
        )]
    public class CliniqueEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CliniqueMigrationsDbContext>();
        }
    }
}
