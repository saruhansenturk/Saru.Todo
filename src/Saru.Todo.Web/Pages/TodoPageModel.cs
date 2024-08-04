using Saru.Todo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Saru.Todo.Web.Pages;

public abstract class TodoPageModel : AbpPageModel
{
    protected TodoPageModel()
    {
        LocalizationResourceType = typeof(TodoResource);
    }
}
