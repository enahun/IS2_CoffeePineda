using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IS2_BodegaPineda.Startup))]
namespace IS2_BodegaPineda
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
