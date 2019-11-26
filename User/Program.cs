using System;
using System.Net;

namespace User
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            //user.Init(IPAddress.Loopback.ToString(), 8000);
            user.Start();

            // Console.WriteLine(user.Receive());
        }
    }
}
