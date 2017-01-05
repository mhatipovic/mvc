using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESTfulDemo.Startup))]
namespace RESTfulDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
