using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICareHealth.Web.Startup))]
namespace ICareHealth.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
