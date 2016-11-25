using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoComplete.Startup))]
namespace AutoComplete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
