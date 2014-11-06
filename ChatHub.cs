using Microsoft.AspNet.SignalR;

namespace SignalRDemo
{
    public class ChatHub : Hub
    {
        public void Send(Message message)
        {
            Clients.All.receive(message.Who + " said " + message.What);
        }
    }
}