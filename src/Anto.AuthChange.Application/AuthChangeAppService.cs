using System;
using System.Collections.Generic;
using System.Text;
using Anto.AuthChange.Localization;
using Volo.Abp.Application.Services;

namespace Anto.AuthChange
{
    /* Inherit your application services from this class.
     */
    public abstract class AuthChangeAppService : ApplicationService
    {
        protected AuthChangeAppService()
        {
            LocalizationResource = typeof(AuthChangeResource);
        }
    }
}
