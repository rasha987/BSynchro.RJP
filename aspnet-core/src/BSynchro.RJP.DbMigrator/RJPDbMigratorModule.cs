using BSynchro.RJP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BSynchro.RJP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RJPEntityFrameworkCoreModule),
    typeof(RJPApplicationContractsModule)
    )]
public class RJPDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
