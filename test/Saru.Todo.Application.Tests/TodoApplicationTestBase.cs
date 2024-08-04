using Volo.Abp.Modularity;

namespace Saru.Todo;

public abstract class TodoApplicationTestBase<TStartupModule> : TodoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
