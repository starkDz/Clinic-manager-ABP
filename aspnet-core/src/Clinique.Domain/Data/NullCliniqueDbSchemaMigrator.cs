using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Clinique.Data
{
    /* This is used if database provider does't define
     * ICliniqueDbSchemaMigrator implementation.
     */
    public class NullCliniqueDbSchemaMigrator : ICliniqueDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}