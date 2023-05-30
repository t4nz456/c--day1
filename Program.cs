using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Contact Information: ");
            string contactInformation = Console.ReadLine();
            Console.WriteLine(name + " " + age + " " + contactInformation);
        }
    }
}