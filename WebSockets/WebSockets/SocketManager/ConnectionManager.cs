using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Threading;

namespace WebSockets.SocketManager
{
    public class ConnectionManager
    {
        private ConcurrentDictionary<String, WebSocket> connections = new ConcurrentDictionary<string, WebSocket>();

        public WebSocket GetSocketByID(String id)
        {
            return connections.FirstOrDefault(x => x.Key == id).Value;
        }

        public ConcurrentDictionary<string,WebSocket> GetAllConnections()
        {
            return connections;
        }

        public string GetId(WebSocket socket)
        {
            return connections.FirstOrDefault(x => x.Value == socket).Key;
        }
        
        public async Task RemoveSocketAsync(String id)
        {
            connections.TryRemove(id, out var socket);
            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "socket connection closed", CancellationToken.None);

        }

        public void AddSocket(WebSocket socket)
        {
            connections.TryAdd(GetConnectionId(), socket);
        }
        private string GetConnectionId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
