using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Anto.AuthChange.EntityFrameworkCore
{
    [DependsOn(
        typeof(AuthChangeEntityFrameworkCoreModule)
        )]
    public class AuthChangeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AuthChangeMigrationsDbContext>();
        }
    }
}
