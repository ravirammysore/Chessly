using Chessly.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chessly.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ChesslyController : AbpControllerBase
{
    protected ChesslyController()
    {
        LocalizationResource = typeof(ChesslyResource);
    }
}
