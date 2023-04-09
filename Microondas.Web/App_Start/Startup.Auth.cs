using Microondas.Web.Providers;

using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;

using Owin;

using System;

namespace Microondas.Web
{
    public partial class Startup
    {
        // Habilitar o aplicativo a usar OAuthAuthorization. Então poderá proteger suas APIs da Web
        static Startup()
        {
            PublicClientId = "web";

            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                AuthorizeEndpointPath = new PathString("/Account/Authorize"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };
        }

        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // Para obter mais informações sobre a autenticação de configuração, visite https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {       
            
        }
    }
}
