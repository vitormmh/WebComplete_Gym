using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebComplete.Startup))]
namespace WebComplete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
