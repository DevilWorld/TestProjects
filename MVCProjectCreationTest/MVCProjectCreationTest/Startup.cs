using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjectCreationTest.Startup))]
namespace MVCProjectCreationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
