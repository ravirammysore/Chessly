using System;
using System.Collections.Generic;
using System.Text;
using Chessly.Localization;
using Volo.Abp.Application.Services;

namespace Chessly;

/* Inherit your application services from this class.
 */
public abstract class ChesslyAppService : ApplicationService
{
    protected ChesslyAppService()
    {
        LocalizationResource = typeof(ChesslyResource);
    }
}
