using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superhero_Project.Startup))]
namespace Superhero_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
