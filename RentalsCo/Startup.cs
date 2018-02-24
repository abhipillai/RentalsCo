using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalsCo.Startup))]
namespace RentalsCo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
