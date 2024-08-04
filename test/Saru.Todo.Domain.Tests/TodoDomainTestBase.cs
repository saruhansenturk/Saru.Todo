using Volo.Abp.Modularity;

namespace Saru.Todo;

/* Inherit from this class for your domain layer tests. */
public abstract class TodoDomainTestBase<TStartupModule> : TodoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
