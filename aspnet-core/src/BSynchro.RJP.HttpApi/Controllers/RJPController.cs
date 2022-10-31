using BSynchro.RJP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BSynchro.RJP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RJPController : AbpControllerBase
{
    protected RJPController()
    {
        LocalizationResource = typeof(RJPResource);
    }
}
