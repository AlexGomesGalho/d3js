using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using WebSockets.SocketManager;

namespace WebSockets.Handlers
{
    public class WebSocketMessageHandler : SocketHandler
    {
        public WebSocketMessageHandler(ConnectionManager connection) : base(connection)
        {

        }

        public override async Task onConnected(WebSocket sockets)
        {
            await base.onConnected(sockets);
            var socketId = Connection.GetId(sockets);
            await SendMessageToAll($"{socketId} just joined the party*******");
        }
        public override async Task Receive(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            var socketId = Connection.GetId(socket);
            var message = $"{socketId} said: {Encoding.UTF8.GetString(buffer, 0, result.Count)}";
            await SendMessageToAll(message);
        }
    }
}
