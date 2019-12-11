using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAS.Startup))]
namespace SAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
