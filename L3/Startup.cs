using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L3.Startup))]
namespace L3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
