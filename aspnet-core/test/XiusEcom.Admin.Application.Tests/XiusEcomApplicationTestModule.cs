using Volo.Abp.Modularity;

namespace XiusEcom.Admin;

[DependsOn(
    typeof(XiusEcomAdminApplicationModule),
    typeof(XiusEcomDomainTestModule)
    )]
public class XiusEcomApplicationTestModule : AbpModule
{

}
