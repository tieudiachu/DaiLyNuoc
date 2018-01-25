using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLDaiLy.Startup))]
namespace QLDaiLy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
