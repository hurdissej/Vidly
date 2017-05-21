using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Empty.Startup))]
namespace Empty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
