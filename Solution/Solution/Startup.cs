using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solution.Startup))]
namespace Solution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
