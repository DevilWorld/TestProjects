using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjectCreationTest1.Startup))]
namespace MVCProjectCreationTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
