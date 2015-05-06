using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibliotecaDigital.Startup))]
namespace BibliotecaDigital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
