using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Darisanam.Web.Startup))]
namespace Darisanam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
