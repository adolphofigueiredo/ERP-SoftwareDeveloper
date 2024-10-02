using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20241001_ASP.NET_WebFormSite.Startup))]
namespace _20241001_ASP.NET_WebFormSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
