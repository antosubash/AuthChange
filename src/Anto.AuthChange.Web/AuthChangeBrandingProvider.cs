using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Anto.AuthChange.Web
{
    [Dependency(ReplaceServices = true)]
    public class AuthChangeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AuthChange";
    }
}
