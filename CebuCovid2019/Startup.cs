using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CebuCovid2019.Startup))]
namespace CebuCovid2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
