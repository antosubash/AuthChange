using Anto.AuthChange.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Anto.AuthChange.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AuthChangeEntityFrameworkCoreDbMigrationsModule),
        typeof(AuthChangeApplicationContractsModule)
        )]
    public class AuthChangeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
