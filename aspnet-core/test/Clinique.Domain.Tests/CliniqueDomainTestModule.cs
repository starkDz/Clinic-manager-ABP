using Clinique.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Clinique
{
    [DependsOn(
        typeof(CliniqueEntityFrameworkCoreTestModule)
        )]
    public class CliniqueDomainTestModule : AbpModule
    {

    }
}