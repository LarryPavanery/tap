using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAP.Startup))]
namespace TAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
