using Xunit;

namespace Saru.Todo.EntityFrameworkCore;

[CollectionDefinition(TodoTestConsts.CollectionDefinitionName)]
public class TodoEntityFrameworkCoreCollection : ICollectionFixture<TodoEntityFrameworkCoreFixture>
{

}
