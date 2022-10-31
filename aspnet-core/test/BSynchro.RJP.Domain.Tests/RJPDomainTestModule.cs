using BSynchro.RJP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BSynchro.RJP;

[DependsOn(
    typeof(RJPEntityFrameworkCoreTestModule)
    )]
public class RJPDomainTestModule : AbpModule
{

}
