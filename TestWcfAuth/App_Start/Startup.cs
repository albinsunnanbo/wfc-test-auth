using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Kentor.AuthServices.Owin;

[assembly: OwinStartup(typeof(TestWcfAuth.App_Start.Startup))]

namespace TestWcfAuth.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                Provider = new CookieAuthenticationProvider(),
                LoginPath = new PathString("/Home/NotAuthorized"),
                ExpireTimeSpan = new TimeSpan(8, 0, 0)
            });
            

            // Set the default signin type, which is what Kentor AuthServices
            // relies on for session handling.
            app.SetDefaultSignInAsAuthenticationType(DefaultAuthenticationTypes.ApplicationCookie);
            app.UseKentorAuthServicesAuthentication(new KentorAuthServicesAuthenticationOptions(true));
        }
    }
}
