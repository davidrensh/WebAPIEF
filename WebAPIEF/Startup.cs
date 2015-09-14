using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(WebAPIEF.Startup))]
namespace WebAPIEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}