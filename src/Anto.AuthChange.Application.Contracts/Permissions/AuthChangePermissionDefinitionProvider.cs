using Anto.AuthChange.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Anto.AuthChange.Permissions
{
    public class AuthChangePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AuthChangePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AuthChangePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AuthChangeResource>(name);
        }
    }
}
