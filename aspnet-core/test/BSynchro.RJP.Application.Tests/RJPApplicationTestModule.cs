using Volo.Abp.Modularity;

namespace BSynchro.RJP;

[DependsOn(
    typeof(RJPApplicationModule),
    typeof(RJPDomainTestModule)
    )]
public class RJPApplicationTestModule : AbpModule
{

}
