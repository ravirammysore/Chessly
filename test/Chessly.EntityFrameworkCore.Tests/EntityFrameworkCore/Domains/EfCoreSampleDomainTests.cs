using Chessly.Samples;
using Xunit;

namespace Chessly.EntityFrameworkCore.Domains;

[Collection(ChesslyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ChesslyEntityFrameworkCoreTestModule>
{

}
