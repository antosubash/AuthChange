using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace AspNet.Security.OAuth.Keycloak
{
    /// <summary>
    /// A class used to setup defaults for all <see cref="KeycloakAuthenticationOptions"/>.
    /// </summary>
    public class KeycloakPostConfigureOptions : IPostConfigureOptions<KeycloakAuthenticationOptions>
    {
        public void PostConfigure([NotNull] string name, [NotNull] KeycloakAuthenticationOptions options)
        {
            if (!string.IsNullOrWhiteSpace(options.BaseUrl))
            {
                options.AuthorizationEndpoint = options.BaseUrl + KeycloakAuthenticationDefaults.AuthorizationEndpoint;
                options.TokenEndpoint = options.BaseUrl + KeycloakAuthenticationDefaults.TokenEndpoint;
                options.UserInformationEndpoint = options.BaseUrl + KeycloakAuthenticationDefaults.UserInformationEndpoint;
            }
        }
    }
}
