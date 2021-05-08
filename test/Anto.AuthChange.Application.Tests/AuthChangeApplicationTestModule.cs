using Volo.Abp.Modularity;

namespace Anto.AuthChange
{
    [DependsOn(
        typeof(AuthChangeApplicationModule),
        typeof(AuthChangeDomainTestModule)
        )]
    public class AuthChangeApplicationTestModule : AbpModule
    {

    }
}