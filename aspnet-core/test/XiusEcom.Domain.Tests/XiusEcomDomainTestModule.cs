using XiusEcom.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XiusEcom;

[DependsOn(
    typeof(XiusEcomEntityFrameworkCoreTestModule)
    )]
public class XiusEcomDomainTestModule : AbpModule
{

}
