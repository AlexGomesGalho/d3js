using Microsoft.AspNetCore.Http;
using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WebSockets.SocketManager
{
    internal class SocketMiddelware
    {
        private readonly RequestDelegate _next;

        public SocketMiddelware(RequestDelegate next)
        {
            _next = next;
            Handler = Handler;
        }
        private SocketHandler Handler { get; set; }

        public async  Task InvokeAsync(HttpContext context)
        {
            if (!context.WebSockets.IsWebSocketRequest)
                return;
            var socket = await context.WebSockets.AcceptWebSocketAsync();
            await Handler.onConnected(socket);
            await Receive(socket, async (result, buffer) => { 
            if (result.MessageType == WebSocketMessageType.Text)
                {
                    await Handler.Receive(socket, result, buffer);
                } 
                else if(result.MessageType == WebSocketMessageType.Close)
                {
                    await Handler.OnDisconnected(socket);
                }
            });
        }

        private async Task Receive(WebSocket webSocket, Action<ValueWebSocketReceiveResult,byte[]> messageHandler)
        {
            var buffer = new byte[1024 * 4];
            while(webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer),CancellationToken.None);
                messageHandler(result, buffer);
            }
        }
    }
}
