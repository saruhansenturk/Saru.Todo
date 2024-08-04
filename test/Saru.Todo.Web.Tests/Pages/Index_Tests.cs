using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Saru.Todo.Pages;

[Collection(TodoTestConsts.CollectionDefinitionName)]
public class Index_Tests : TodoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
