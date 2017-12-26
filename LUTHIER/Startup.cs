using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LUTHIER.Startup))]
namespace LUTHIER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
