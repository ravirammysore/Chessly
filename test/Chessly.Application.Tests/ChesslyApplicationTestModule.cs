using Volo.Abp.Modularity;

namespace Chessly;

[DependsOn(
    typeof(ChesslyApplicationModule),
    typeof(ChesslyDomainTestModule)
)]
public class ChesslyApplicationTestModule : AbpModule
{

}
