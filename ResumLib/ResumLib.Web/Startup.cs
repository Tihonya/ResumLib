using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumLib.Web.Startup))]
namespace ResumLib.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
