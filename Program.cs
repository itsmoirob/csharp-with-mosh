using System;

namespace _02_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cookie = new HttpCookie();
            cookie["name"] = "Robbie";
            Console.WriteLine(cookie["name"]);

        }
    }
}
