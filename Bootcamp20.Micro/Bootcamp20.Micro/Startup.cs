using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bootcamp20.Micro.Startup))]
namespace Bootcamp20.Micro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
