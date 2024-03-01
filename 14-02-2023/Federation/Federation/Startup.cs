using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Federation.Startup))]
namespace Federation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
