using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crowdsourcing.Startup))]
namespace Crowdsourcing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
