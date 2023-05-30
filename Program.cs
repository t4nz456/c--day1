using System;

namespace HelloWorld


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Job: ");
            string job = Console.ReadLine();
            Console.WriteLine("Contact information: ");
            string contact = Console.ReadLine();
            Console.WriteLine(name + " " + job + " " + contact);

        }
    }
}
