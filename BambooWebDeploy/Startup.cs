using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BambooWebDeploy.Startup))]
namespace BambooWebDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
