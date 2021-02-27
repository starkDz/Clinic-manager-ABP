using Clinique.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Clinique.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CliniqueEntityFrameworkCoreDbMigrationsModule),
        typeof(CliniqueApplicationContractsModule)
        )]
    public class CliniqueDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
