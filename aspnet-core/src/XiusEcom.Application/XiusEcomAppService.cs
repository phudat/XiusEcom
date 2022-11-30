using System;
using System.Collections.Generic;
using System.Text;
using XiusEcom.Localization;
using Volo.Abp.Application.Services;

namespace XiusEcom;

/* Inherit your application services from this class.
 */
public abstract class XiusEcomAppService : ApplicationService
{
    protected XiusEcomAppService()
    {
        LocalizationResource = typeof(XiusEcomResource);
    }
}
