using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioTecnicoDotNet.Startup))]
namespace EjercicioTecnicoDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
