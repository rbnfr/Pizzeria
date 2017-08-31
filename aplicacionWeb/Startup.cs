using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aplicacionWeb.Startup))]
namespace aplicacionWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
