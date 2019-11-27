using System;
using System.Net.Sockets;
using System.Text;

namespace User
{
    public class User
    {
        private readonly TcpClient client;
        private NetworkStream networkStream;

        public User()
        {
            client = new TcpClient();
        }

        public string Ip { get; set; }
        public int Port { get; set; }

        public void ReceiveFromServer()
        {
            byte[] received = new byte[255];
            networkStream.Read(received, 0, received.Length);

            Console.WriteLine(Encoding.ASCII.GetString(received, 0, received.Length));

            networkStream.Close();
            client.Close();
        }

        public void Start()
        {
            Connect();
        }

        private void Connect()
        {
            client.Connect("127.0.0.1", 8000);
            networkStream = client.GetStream();
        }
    }
}