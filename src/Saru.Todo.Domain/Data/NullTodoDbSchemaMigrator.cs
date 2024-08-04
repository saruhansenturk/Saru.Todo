using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Saru.Todo.Data;

/* This is used if database provider does't define
 * ITodoDbSchemaMigrator implementation.
 */
public class NullTodoDbSchemaMigrator : ITodoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
