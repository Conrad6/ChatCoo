using Microsoft.AspNetCore.SignalR;

namespace ChatCoo;

public class ChatHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        await Clients.All.SendAsync("ReceiveMessage");
    }
}
