using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanTrackerWeb.Startup))]
namespace PlanTrackerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
