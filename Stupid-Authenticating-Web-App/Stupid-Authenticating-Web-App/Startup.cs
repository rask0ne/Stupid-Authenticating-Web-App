using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stupid_Authenticating_Web_App.Startup))]
namespace Stupid_Authenticating_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
