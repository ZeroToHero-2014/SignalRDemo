using Microsoft.AspNet.SignalR;

namespace SignalRDemo
{
    public class ChatHub : Hub
    {
        public void SendHello(string what)
        {
            Clients.All.ReceiveHello("someone said " + what);
        }
    }
}