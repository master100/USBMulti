using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(USBMulti.Startup))]
namespace USBMulti
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
