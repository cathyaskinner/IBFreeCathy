using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBFree.Startup))]
namespace IBFree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
