using Volo.Abp.Settings;

namespace Saru.Todo.Settings;

public class TodoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TodoSettings.MySetting1));
    }
}
