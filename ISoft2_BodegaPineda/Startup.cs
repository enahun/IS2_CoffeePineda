using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISoft2_BodegaPineda.Startup))]
namespace ISoft2_BodegaPineda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
