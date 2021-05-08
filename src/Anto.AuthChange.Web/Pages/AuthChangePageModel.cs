using Anto.AuthChange.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Anto.AuthChange.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AuthChangePageModel : AbpPageModel
    {
        protected AuthChangePageModel()
        {
            LocalizationResourceType = typeof(AuthChangeResource);
        }
    }
}