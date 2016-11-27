using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversitySchedule.Startup))]
namespace UniversitySchedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
