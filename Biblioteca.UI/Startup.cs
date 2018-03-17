using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biblioteca.UI.Startup))]
namespace Biblioteca.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
