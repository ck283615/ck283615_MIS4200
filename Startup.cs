using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ck283615_MIS4200.Startup))]
namespace ck283615_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
