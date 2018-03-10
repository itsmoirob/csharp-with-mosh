using System;

namespace _02_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new AccessModPerson();
            person.SetBirthdate(new DateTime(1982, 2, 12));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
