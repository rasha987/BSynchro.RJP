using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BSynchro.RJP.Data;

/* This is used if database provider does't define
 * IRJPDbSchemaMigrator implementation.
 */
public class NullRJPDbSchemaMigrator : IRJPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
