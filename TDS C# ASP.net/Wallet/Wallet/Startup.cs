using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(Wallet.Startup))]

namespace Wallet
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/auth/login")
            });
        }
    }
    public class FilterConfig
    {
        public static void RegisterGlobalFilter(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
