using System;

namespace NotificationServer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationServer ns = new NotificationServer();
            ns.Send();
            Console.WriteLine("Hello World!");
        }
    }
}
