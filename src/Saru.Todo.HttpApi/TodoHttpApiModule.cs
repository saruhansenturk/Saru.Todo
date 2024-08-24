using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using Saru.Todo.Localization;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.TenantManagement;

namespace Saru.Todo;

[DependsOn(
   typeof(TodoApplicationContractsModule),
   typeof(AbpPermissionManagementHttpApiModule),
   typeof(AbpSettingManagementHttpApiModule),
   typeof(AbpAccountHttpApiModule),
   typeof(AbpIdentityHttpApiModule),
   typeof(AbpTenantManagementHttpApiModule),
   typeof(AbpFeatureManagementHttpApiModule)
   )]
public class TodoHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();

    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TodoResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
