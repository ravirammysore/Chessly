using Volo.Abp.Modularity;

namespace Chessly;

public abstract class ChesslyApplicationTestBase<TStartupModule> : ChesslyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
