using System.Threading.Tasks;

namespace Saru.Todo.Data;

public interface ITodoDbSchemaMigrator
{
    Task MigrateAsync();
}
