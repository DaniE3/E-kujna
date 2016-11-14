using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_kujna.Startup))]
namespace E_kujna
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
