using Microsoft.AspNetCore.SignalR;

namespace signalr_team.IoTHub
{
    public class IoTHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
