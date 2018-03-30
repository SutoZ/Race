using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Race.Startup))]
namespace Race
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
