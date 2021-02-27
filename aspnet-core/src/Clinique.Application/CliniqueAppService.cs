using System;
using System.Collections.Generic;
using System.Text;
using Clinique.Localization;
using Volo.Abp.Application.Services;

namespace Clinique
{
    /* Inherit your application services from this class.
     */
    public abstract class CliniqueAppService : ApplicationService
    {
        protected CliniqueAppService()
        {
            LocalizationResource = typeof(CliniqueResource);
        }
    }
}
