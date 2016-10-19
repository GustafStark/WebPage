using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRMVer4.Startup))]
namespace HRMVer4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
