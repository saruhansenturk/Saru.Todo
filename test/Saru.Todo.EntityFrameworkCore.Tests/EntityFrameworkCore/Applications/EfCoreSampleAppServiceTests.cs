using Saru.Todo.Samples;
using Xunit;

namespace Saru.Todo.EntityFrameworkCore.Applications;

[Collection(TodoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TodoEntityFrameworkCoreTestModule>
{

}
