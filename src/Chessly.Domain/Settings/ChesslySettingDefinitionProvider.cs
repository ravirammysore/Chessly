using Volo.Abp.Settings;

namespace Chessly.Settings;

public class ChesslySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ChesslySettings.MySetting1));
    }
}
