using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSockets.SocketManager
{
    public abstract class SocketHandler
    {
        public ConnectionManager Connection { get; set; }

        public SocketHandler(ConnectionManager connection)
        {
            Connection = connection;
        }

        public virtual async Task onConnected(WebSocket sockets)
        {
            await Task.Run(() => { Connection.AddSocket(sockets); });   
        }

        public virtual async Task OnDisconnected(WebSocket socket)
        {
            await Connection.RemoveSocketAsync(Connection.GetId(socket));
        }

        public async Task SendMessage(WebSocket socket,string message)
        {
            if (socket.State != WebSocketState.Open)
                return;
            await socket.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes(message), 0, message.Length), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        internal Task Receive(WebSocket socket, ValueWebSocketReceiveResult result, byte[] buffer)
        {
            throw new NotImplementedException();
        }

        public async Task SendMessage(string id,string message)
        {
            await SendMessage(Connection.GetSocketByID(id), message);
        }

        public async Task SendMessageToAll(string message)
        {
            foreach (var con in Connection.GetAllConnections())
                await SendMessage(con.Value, message);
        }

        public abstract Task Receive(WebSocket socket, WebSocketReceiveResult result, byte[] buffer);
    }
 }
