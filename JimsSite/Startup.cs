using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JimsSite.Startup))]
namespace JimsSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
