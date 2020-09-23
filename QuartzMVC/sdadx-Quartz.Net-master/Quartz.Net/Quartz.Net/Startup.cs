using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quartz.Net.Startup))]
namespace Quartz.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
