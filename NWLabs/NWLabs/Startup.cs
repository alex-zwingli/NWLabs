using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWLabs.Startup))]
namespace NWLabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
