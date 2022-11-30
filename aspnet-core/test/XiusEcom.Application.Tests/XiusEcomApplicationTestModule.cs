using Volo.Abp.Modularity;

namespace XiusEcom;

[DependsOn(
    typeof(XiusEcomApplicationModule),
    typeof(XiusEcomDomainTestModule)
    )]
public class XiusEcomApplicationTestModule : AbpModule
{

}
