using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BlazorDemo.CRM.Components.Account {
    public class CookieEvents : CookieAuthenticationEvents {
        public override Task RedirectToLogin(RedirectContext<CookieAuthenticationOptions> context) {
            var path = context.Request.Path;
            var redirectUri = UriHelper.BuildRelative(
                context.Request.PathBase,
                "/Account/Login",
                QueryString.Create("ReturnUrl", path.HasValue ? path.Value.TrimStart('/') : string.Empty)
            );
            context.RedirectUri = redirectUri;
            return base.RedirectToLogin(context);
        }
    }
}
