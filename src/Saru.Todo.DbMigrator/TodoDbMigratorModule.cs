using Saru.Todo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Saru.Todo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoEntityFrameworkCoreModule),
    typeof(TodoApplicationContractsModule)
)]
public class TodoDbMigratorModule : AbpModule
{
}
