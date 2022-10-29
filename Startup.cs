using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThreeLayer.Startup))]
namespace ThreeLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
