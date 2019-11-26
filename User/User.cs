using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace User
{
    public class User
    {
        private bool initialized;
        private TcpClient client;
        private NetworkStream networkStream;

        public string Ip { get; set; }
        public int Port { get; set; }

        public User()
        {
            client = new TcpClient();
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
