using Volo.Abp.Settings;

namespace BSynchro.RJP.Settings;

public class RJPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RJPSettings.MySetting1));
    }
}
