using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuskyAir.Startup))]
namespace HuskyAir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
