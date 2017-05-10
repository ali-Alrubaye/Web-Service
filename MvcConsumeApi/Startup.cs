using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcConsumeApi.Startup))]
namespace MvcConsumeApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
