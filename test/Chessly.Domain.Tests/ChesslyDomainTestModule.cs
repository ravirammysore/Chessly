using Volo.Abp.Modularity;

namespace Chessly;

[DependsOn(
    typeof(ChesslyDomainModule),
    typeof(ChesslyTestBaseModule)
)]
public class ChesslyDomainTestModule : AbpModule
{

}
