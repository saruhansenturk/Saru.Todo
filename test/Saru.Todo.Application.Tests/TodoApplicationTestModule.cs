using Volo.Abp.Modularity;

namespace Saru.Todo;

[DependsOn(
    typeof(TodoApplicationModule),
    typeof(TodoDomainTestModule)
)]
public class TodoApplicationTestModule : AbpModule
{

}
