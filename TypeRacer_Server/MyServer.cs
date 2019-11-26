using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TypeRacer_Server
{
#pragma warning disable CA1001 // Types that own disposable fields should be disposable

    public class MyServer
#pragma warning restore CA1001 // Types that own disposable fields should be disposable
    {
        private const int Port = 8000;
#pragma warning disable S1450 // Private fields only used as local variables in methods should become local variables
        private readonly IPEndPoint endPoint;
        private TcpListener listener;
        private NetworkStream stream;
#pragma warning restore S1450 // Private fields only used as local variables in methods should become local variables

        public MyServer()
        {
            endPoint = new IPEndPoint(IPAddress.Loopback, Port);
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), Port);
        }

        public void Start()
        {
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                stream = client.GetStream();

                byte[] buffer = new byte[255];
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}