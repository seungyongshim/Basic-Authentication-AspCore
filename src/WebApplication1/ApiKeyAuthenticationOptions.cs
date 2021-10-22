using Microsoft.AspNetCore.Authentication;

namespace WebApplication1
{
    public class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "ApiKey";
        public string Scheme => DefaultScheme;
        public string AuthenticationType => DefaultScheme;
    }
}
