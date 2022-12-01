using XiusEcom.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XiusEcom.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class XiusEcomController : AbpControllerBase
{
    protected XiusEcomController()
    {
        LocalizationResource = typeof(XiusEcomResource);
    }
}
