using System;
using System.Collections.Generic;
using System.Text;
using BSynchro.RJP.Localization;
using Volo.Abp.Application.Services;

namespace BSynchro.RJP;

/* Inherit your application services from this class.
 */
public abstract class RJPAppService : ApplicationService
{
    protected RJPAppService()
    {
        LocalizationResource = typeof(RJPResource);
    }
}
