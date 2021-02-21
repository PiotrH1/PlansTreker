using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanTracker.Web.Startup))]
namespace PlanTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
