using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Chessly.Pages;

public class Index_Tests : ChesslyWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
