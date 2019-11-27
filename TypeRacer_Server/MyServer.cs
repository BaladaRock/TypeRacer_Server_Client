using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TypeRacer_Server
{
    public class MyServer
    {
        private const int Port = 8000;
        private readonly TcpListener listener;

        public MyServer()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, Port);
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), Port);
        }

        public void Start()
        {
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                byte[] buffer = null;

                var text = new ContestText();
                buffer = Encoding.ASCII.GetBytes(text.GetText());

                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}