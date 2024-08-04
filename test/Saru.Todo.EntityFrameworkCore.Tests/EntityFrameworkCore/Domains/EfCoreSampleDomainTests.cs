using Saru.Todo.Samples;
using Xunit;

namespace Saru.Todo.EntityFrameworkCore.Domains;

[Collection(TodoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TodoEntityFrameworkCoreTestModule>
{

}
