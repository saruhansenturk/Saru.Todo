using Volo.Abp.Modularity;

namespace Saru.Todo;

[DependsOn(
    typeof(TodoDomainModule),
    typeof(TodoTestBaseModule)
)]
public class TodoDomainTestModule : AbpModule
{

}
