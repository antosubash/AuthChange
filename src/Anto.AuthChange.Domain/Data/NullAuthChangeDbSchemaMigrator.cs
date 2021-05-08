using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Anto.AuthChange.Data
{
    /* This is used if database provider does't define
     * IAuthChangeDbSchemaMigrator implementation.
     */
    public class NullAuthChangeDbSchemaMigrator : IAuthChangeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}