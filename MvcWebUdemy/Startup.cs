using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebUdemy.Startup))]
namespace MvcWebUdemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
