using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicCity.Startup))]
namespace MusicCity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
