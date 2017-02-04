using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Bootstrap3.EF6.DatabaseFirst.Startup))]
namespace MVC.Bootstrap3.EF6.DatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
