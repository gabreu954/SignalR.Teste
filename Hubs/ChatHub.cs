using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Teste.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message, int contador)
        {
            Clients.Caller.SendAsync("ReceiveMessage", message, contador);
        }
    }
}
