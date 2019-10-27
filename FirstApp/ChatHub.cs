using Microsoft.AspNet.SignalR;

namespace FirstApp
{
    public class ChatHub : Hub
    {
        public void Hello(string message)
        {
            Clients.All.Hello(message);
        }
    }
}