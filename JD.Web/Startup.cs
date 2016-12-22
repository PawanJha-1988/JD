using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JD.Web.Startup))]
namespace JD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
