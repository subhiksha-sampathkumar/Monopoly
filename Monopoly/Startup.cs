using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monopoly.Startup))]
namespace Monopoly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
