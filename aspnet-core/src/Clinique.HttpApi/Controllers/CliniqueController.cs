using Clinique.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Clinique.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CliniqueController : AbpController
    {
        protected CliniqueController()
        {
            LocalizationResource = typeof(CliniqueResource);
        }
    }
}