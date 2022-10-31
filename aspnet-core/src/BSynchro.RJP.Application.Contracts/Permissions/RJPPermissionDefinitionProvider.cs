using BSynchro.RJP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BSynchro.RJP.Permissions;

public class RJPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RJPPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RJPPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RJPResource>(name);
    }
}
