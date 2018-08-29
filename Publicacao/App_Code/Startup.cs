using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Publicacao.Startup))]
namespace Publicacao
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
