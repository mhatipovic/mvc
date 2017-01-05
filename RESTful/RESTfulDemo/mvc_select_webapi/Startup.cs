using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_select_webapi.Startup))]
namespace mvc_select_webapi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
