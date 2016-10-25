using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_404.Startup))]
namespace _404
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
