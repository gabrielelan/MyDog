using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDog.Startup))]
namespace MyDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
