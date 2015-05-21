using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoticiaApp.Startup))]
namespace NoticiaApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
