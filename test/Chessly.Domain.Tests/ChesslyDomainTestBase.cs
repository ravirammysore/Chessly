using Volo.Abp.Modularity;

namespace Chessly;

/* Inherit from this class for your domain layer tests. */
public abstract class ChesslyDomainTestBase<TStartupModule> : ChesslyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
