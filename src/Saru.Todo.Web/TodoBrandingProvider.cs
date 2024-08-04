using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Saru.Todo.Web;

[Dependency(ReplaceServices = true)]
public class TodoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Todo";
}
