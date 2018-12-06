using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iCanDoIT.Startup))]
namespace iCanDoIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
