using Microsoft.AspNet.SignalR;

namespace SignalrDemo
{
    public class ChatHub : Hub
    {
        public void Send(string text)
        {
            Clients.Caller.ShowMessage("You wrote: " + text);
            Clients.Others.ShowMessage(Clients.Caller.Nickname + " wrote: " + text);
        }
    }
}