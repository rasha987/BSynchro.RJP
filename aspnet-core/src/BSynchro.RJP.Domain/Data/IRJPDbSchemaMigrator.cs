using System.Threading.Tasks;

namespace BSynchro.RJP.Data;

public interface IRJPDbSchemaMigrator
{
    Task MigrateAsync();
}
