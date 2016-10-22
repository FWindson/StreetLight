using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StreetLight.Startup))]
namespace StreetLight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
