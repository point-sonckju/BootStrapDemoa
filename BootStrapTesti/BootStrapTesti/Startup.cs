using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapTesti.Startup))]
namespace BootStrapTesti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
