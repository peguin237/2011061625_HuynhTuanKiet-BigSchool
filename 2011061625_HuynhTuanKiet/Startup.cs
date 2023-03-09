using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011061625_HuynhTuanKiet.Startup))]
namespace _2011061625_HuynhTuanKiet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
