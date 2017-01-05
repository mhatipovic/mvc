using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQuery_demo.Startup))]
namespace jQuery_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
