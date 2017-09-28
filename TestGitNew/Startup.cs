using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitNew.Startup))]
namespace TestGitNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
