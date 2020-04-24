using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sck.Bind(new IPEndPoint(0, 1994));
            sck.Listen(0);

            Socket acc = sck.Accept();

            byte[] buffer = Encoding.Default.GetBytes("Hello Client!");

            acc.Send(buffer, 0, buffer.Length, 0);

            buffer = new byte[255];

            int rec = acc.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("Recevied : {0}", Encoding.Default.GetString(buffer));

            sck.Close();
            acc.Close();

            Console.Read();
        }
    }
}
