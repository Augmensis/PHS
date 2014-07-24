using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivateHomeServices.Startup))]
namespace PrivateHomeServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
