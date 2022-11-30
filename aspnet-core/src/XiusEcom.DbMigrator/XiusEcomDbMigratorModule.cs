using XiusEcom.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace XiusEcom.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(XiusEcomEntityFrameworkCoreModule),
    typeof(XiusEcomApplicationContractsModule)
    )]
public class XiusEcomDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
