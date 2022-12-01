using System;
using System.Collections.Generic;
using System.Text;
using XiusEcom.Localization;
using Volo.Abp.Application.Services;

namespace XiusEcom.Admin;

/* Inherit your application services from this class.
 */
public abstract class XiusEcomAdminAppService : ApplicationService
{
    protected XiusEcomAdminAppService()
    {
        LocalizationResource = typeof(XiusEcomResource);
    }
}
