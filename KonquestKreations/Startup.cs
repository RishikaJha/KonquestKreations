using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KonquestKreations.Startup))]
namespace KonquestKreations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
