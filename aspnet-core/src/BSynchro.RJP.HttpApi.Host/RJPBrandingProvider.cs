using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BSynchro.RJP;

[Dependency(ReplaceServices = true)]
public class RJPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RJP";
}
