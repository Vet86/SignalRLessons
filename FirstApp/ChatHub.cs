using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace FirstApp
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void Hello(string message)
        {
            Clients.All.Hello(message);
        }
    }
}