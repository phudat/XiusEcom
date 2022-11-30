using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace XiusEcom.Data;

/* This is used if database provider does't define
 * IXiusEcomDbSchemaMigrator implementation.
 */
public class NullXiusEcomDbSchemaMigrator : IXiusEcomDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
