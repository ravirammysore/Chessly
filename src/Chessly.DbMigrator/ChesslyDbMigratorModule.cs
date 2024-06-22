using Chessly.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Chessly.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ChesslyEntityFrameworkCoreModule),
    typeof(ChesslyApplicationContractsModule)
    )]
public class ChesslyDbMigratorModule : AbpModule
{
}
