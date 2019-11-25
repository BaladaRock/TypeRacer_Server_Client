using System;
using System.Net;

namespace User
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Init(Dns.GetHostEntry("localHost").AddressList[0].ToString(), 8000);
            user.Send("Impostor");
            Console.WriteLine(user.Receive());
        }
    }
}
