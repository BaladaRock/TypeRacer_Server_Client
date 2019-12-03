using System;

namespace TypeRacer_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new MyServer();
            server.Start();
        }
    }
}