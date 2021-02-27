using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Clinique
{
    [Dependency(ReplaceServices = true)]
    public class CliniqueBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Clinique";
    }
}
