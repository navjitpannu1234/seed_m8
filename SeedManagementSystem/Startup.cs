using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeedManagementSystem.Startup))]
namespace SeedManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
