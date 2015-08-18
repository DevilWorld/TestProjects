using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularController.Startup))]
namespace AngularController
{

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }

}
