using Volo.Abp.Modularity;

namespace Clinique
{
    [DependsOn(
        typeof(CliniqueApplicationModule),
        typeof(CliniqueDomainTestModule)
        )]
    public class CliniqueApplicationTestModule : AbpModule
    {

    }
}