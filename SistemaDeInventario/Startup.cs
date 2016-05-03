using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaDeInventario.Startup))]
namespace SistemaDeInventario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
