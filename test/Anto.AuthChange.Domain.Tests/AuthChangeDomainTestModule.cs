using Anto.AuthChange.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Anto.AuthChange
{
    [DependsOn(
        typeof(AuthChangeEntityFrameworkCoreTestModule)
        )]
    public class AuthChangeDomainTestModule : AbpModule
    {

    }
}