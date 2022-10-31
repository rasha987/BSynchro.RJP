using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BSynchro.RJP.Data;
using Volo.Abp.DependencyInjection;

namespace BSynchro.RJP.EntityFrameworkCore;

public class EntityFrameworkCoreRJPDbSchemaMigrator
    : IRJPDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRJPDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the RJPDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RJPDbContext>()
            .Database
            .MigrateAsync();
    }
}
