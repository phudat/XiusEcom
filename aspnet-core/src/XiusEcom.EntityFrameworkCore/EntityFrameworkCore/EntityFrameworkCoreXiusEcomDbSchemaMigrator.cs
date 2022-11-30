using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XiusEcom.Data;
using Volo.Abp.DependencyInjection;

namespace XiusEcom.EntityFrameworkCore;

public class EntityFrameworkCoreXiusEcomDbSchemaMigrator
    : IXiusEcomDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreXiusEcomDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the XiusEcomDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<XiusEcomDbContext>()
            .Database
            .MigrateAsync();
    }
}
