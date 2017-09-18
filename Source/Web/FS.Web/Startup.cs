using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FS.Web.Startup))]
namespace FS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
