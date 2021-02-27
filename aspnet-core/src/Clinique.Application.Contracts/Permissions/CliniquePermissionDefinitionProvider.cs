using Clinique.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Clinique.Permissions
{
    public class CliniquePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CliniquePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CliniquePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CliniqueResource>(name);
        }
    }
}
