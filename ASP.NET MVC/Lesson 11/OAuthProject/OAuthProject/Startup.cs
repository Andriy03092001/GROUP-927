using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthProject.Startup))]
namespace OAuthProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
