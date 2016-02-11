using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GregsWebFormSplitCheck.Startup))]
namespace GregsWebFormSplitCheck
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
