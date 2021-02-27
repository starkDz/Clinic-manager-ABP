using Volo.Abp.Settings;

namespace Clinique.Settings
{
    public class CliniqueSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CliniqueSettings.MySetting1));
        }
    }
}
