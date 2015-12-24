using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuelUp.Startup))]
namespace FuelUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
