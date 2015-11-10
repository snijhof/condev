using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuousDelivery.Startup))]
namespace ContinuousDelivery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
