using Volo.Abp.Settings;

namespace XiusEcom.Settings;

public class XiusEcomSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(XiusEcomSettings.MySetting1));
    }
}
