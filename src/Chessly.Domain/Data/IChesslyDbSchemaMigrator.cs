using System.Threading.Tasks;

namespace Chessly.Data;

public interface IChesslyDbSchemaMigrator
{
    Task MigrateAsync();
}
