using Volo.Abp.Settings;

namespace Anto.AuthChange.Settings
{
    public class AuthChangeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AuthChangeSettings.MySetting1));
        }
    }
}
