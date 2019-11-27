namespace User
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var user = new User();
            user.Start();
            user.ReceiveFromServer();
        }
    }
}