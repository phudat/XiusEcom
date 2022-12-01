using XiusEcom.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XiusEcom.Admin.Permissions;

public class XiusEcomPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(XiusEcomPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(XiusEcomPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<XiusEcomResource>(name);
    }
}
