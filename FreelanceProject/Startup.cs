using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreelanceProject.Startup))]
namespace FreelanceProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
