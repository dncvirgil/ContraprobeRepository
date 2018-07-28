using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contraprobe.Startup))]
namespace Contraprobe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
