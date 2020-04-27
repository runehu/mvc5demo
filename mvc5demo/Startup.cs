using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5demo.Startup))]
namespace mvc5demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
