using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dontpanic.Startup))]
namespace dontpanic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
