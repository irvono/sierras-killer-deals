using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SierrasKillerDealsWebApp.Startup))]
namespace SierrasKillerDealsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
