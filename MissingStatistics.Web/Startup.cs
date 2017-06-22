using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissingStatistics.Web.Startup))]
namespace MissingStatistics.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
