using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToasterCutaway.Startup))]
namespace ToasterCutaway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
