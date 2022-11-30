using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XiusEcom;

[Dependency(ReplaceServices = true)]
public class XiusEcomBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "XiusEcom";
}
