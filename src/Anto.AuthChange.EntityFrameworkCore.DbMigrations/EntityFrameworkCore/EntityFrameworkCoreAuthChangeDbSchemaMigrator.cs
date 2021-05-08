using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Anto.AuthChange.Data;
using Volo.Abp.DependencyInjection;

namespace Anto.AuthChange.EntityFrameworkCore
{
    public class EntityFrameworkCoreAuthChangeDbSchemaMigrator
        : IAuthChangeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAuthChangeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AuthChangeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AuthChangeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}