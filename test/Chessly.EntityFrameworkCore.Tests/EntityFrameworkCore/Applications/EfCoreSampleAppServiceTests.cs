using Chessly.Samples;
using Xunit;

namespace Chessly.EntityFrameworkCore.Applications;

[Collection(ChesslyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ChesslyEntityFrameworkCoreTestModule>
{

}
