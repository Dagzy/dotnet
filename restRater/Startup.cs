using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(restRater.Startup))]
namespace restRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
