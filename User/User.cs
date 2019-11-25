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
        private bool initialized = false;
        private static TcpClient client;
        private static NetworkStream networkStream;
        private static StreamReader streamReader;
        private static StreamWriter streamWriter;

        public static string Ip { get; set; }
        public static int Port { get; set; }

        public void Init(string ip, int port)
        {
            Ip = ip;
            Port = port;

            client = new TcpClient(new IPEndPoint(Dns.GetHostEntry("localHost").AddressList[0], Port));
            networkStream = client.GetStream();
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);

            initialized = true;
        }

        public void Send(string data)
        {
            if (initialized)
            {
                streamWriter.WriteLine(data);
                streamWriter.Flush();
            }
        }

        public string Receive()
        {
            string msg = string.Empty;

            if (initialized)
            {
                msg = streamReader.ReadLine();
            }

            return msg;
        }
    }
}
