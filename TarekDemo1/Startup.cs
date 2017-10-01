using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TarekDemo1.Startup))]
namespace TarekDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
