using Anto.AuthChange.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Anto.AuthChange.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AuthChangeController : AbpController
    {
        protected AuthChangeController()
        {
            LocalizationResource = typeof(AuthChangeResource);
        }
    }
}