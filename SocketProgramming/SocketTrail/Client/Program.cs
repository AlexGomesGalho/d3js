using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994);
            sck.Connect(endPoint);

            Console.WriteLine("ENter Message: ");
            string msg = Console.ReadLine();
            byte[] messBuffer = Encoding.Default.GetBytes(msg);
            sck.Send(messBuffer, 0, messBuffer.Length, 0);

            byte[] buffer = new byte[255];
            int rec = sck.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("Recieved : {0}",Encoding.Default.GetString(buffer));

            sck.Close();
            Console.Read();
        }
    }
}
