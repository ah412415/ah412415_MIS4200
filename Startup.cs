using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ah412415_MIS4200.Startup))]
namespace ah412415_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
