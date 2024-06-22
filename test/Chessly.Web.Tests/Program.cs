using Microsoft.AspNetCore.Builder;
using Chessly;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ChesslyWebTestModule>();

public partial class Program
{
}
