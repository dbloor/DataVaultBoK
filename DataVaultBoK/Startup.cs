using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataVaultBoK.Startup))]
namespace DataVaultBoK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
