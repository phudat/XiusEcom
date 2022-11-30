using System.Threading.Tasks;

namespace XiusEcom.Data;

public interface IXiusEcomDbSchemaMigrator
{
    Task MigrateAsync();
}
