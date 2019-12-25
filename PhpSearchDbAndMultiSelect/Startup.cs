using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhpSearchDbAndMultiSelect.Startup))]
namespace PhpSearchDbAndMultiSelect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
