using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomizingIdentityFramework.Startup))]
namespace CustomizingIdentityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
