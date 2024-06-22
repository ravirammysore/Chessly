using Chessly.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Chessly.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ChesslyPageModel : AbpPageModel
{
    protected ChesslyPageModel()
    {
        LocalizationResourceType = typeof(ChesslyResource);
    }
}
