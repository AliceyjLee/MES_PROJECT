using Microsoft.AspNetCore.SignalR;

namespace signalr_team.ImgHub
{
    public class ImgHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Console.Out.WriteLineAsync(message);
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
