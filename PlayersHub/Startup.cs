using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayersHub.Startup))]
namespace PlayersHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
