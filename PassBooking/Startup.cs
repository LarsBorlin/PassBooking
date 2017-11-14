using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassBooking.Startup))]
namespace PassBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
