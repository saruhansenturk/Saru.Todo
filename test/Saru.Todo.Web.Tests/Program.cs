using Microsoft.AspNetCore.Builder;
using Saru.Todo;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<TodoWebTestModule>();

public partial class Program
{
}
