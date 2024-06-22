using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Chessly.Data;

/* This is used if database provider does't define
 * IChesslyDbSchemaMigrator implementation.
 */
public class NullChesslyDbSchemaMigrator : IChesslyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
