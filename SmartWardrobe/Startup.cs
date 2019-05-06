using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartWardrobe.Startup))]
namespace SmartWardrobe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
