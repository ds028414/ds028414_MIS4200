using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ds028414_MIS4200.Startup))]
namespace ds028414_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
