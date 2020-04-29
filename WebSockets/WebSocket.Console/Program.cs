using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocket.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Count() <= 2)
            {
                Process.Start("WebSocket.Console.exe");
            }
            StartWebSockets().GetAwaiter().GetResult();
        }
        public static async Task StartWebSockets()
        {
            var client = new ClientWebSocket();
            await client.ConnectAsync(new Uri("ws://localhost:5000/ws"), CancellationToken.None);
            Console.WriteLine($"Web socket connection established at {DateTime.UtcNow:F}");


        }

    }
}
