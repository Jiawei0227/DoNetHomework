using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileParserApp.Startup))]
namespace FileParserApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
