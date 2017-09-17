using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCRUDApplicationMVC.Startup))]
namespace SimpleCRUDApplicationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
