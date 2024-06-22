using Xunit;

namespace Chessly.EntityFrameworkCore;

[CollectionDefinition(ChesslyTestConsts.CollectionDefinitionName)]
public class ChesslyEntityFrameworkCoreCollection : ICollectionFixture<ChesslyEntityFrameworkCoreFixture>
{

}
