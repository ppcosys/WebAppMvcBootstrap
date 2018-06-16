using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMvcBootstrap.Startup))]
namespace WebAppMvcBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
