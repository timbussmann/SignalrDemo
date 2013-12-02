using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalrDemo.Startup))]
namespace SignalrDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
