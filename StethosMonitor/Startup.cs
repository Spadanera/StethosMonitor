using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StethosMonitor.Startup))]
namespace StethosMonitor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
