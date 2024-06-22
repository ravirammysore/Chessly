using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Chessly.Web;

[Dependency(ReplaceServices = true)]
public class ChesslyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Chessly";
}
