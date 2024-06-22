using Chessly.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Chessly.Permissions;

public class ChesslyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ChesslyPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ChesslyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ChesslyResource>(name);
    }
}
