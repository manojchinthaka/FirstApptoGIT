using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstApptoGIT.Startup))]
namespace FirstApptoGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
