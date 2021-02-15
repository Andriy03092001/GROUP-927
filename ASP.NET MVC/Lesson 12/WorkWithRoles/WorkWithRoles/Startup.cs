using Microsoft.Owin;
using Owin;
using Roles.Helper;

[assembly: OwinStartupAttribute(typeof(WorkWithRoles.Startup))]
namespace WorkWithRoles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            SeederDatabase.SeedData();
        }
    }
}
