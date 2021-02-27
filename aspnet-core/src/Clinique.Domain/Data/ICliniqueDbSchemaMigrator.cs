using System.Threading.Tasks;

namespace Clinique.Data
{
    public interface ICliniqueDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
