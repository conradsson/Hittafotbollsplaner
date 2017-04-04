using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hittafotbollsplaner.Startup))]
namespace Hittafotbollsplaner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
