using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AudioBook.Startup))]
namespace AudioBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
