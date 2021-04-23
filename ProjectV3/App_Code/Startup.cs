using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectV3.Startup))]
namespace ProjectV3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
