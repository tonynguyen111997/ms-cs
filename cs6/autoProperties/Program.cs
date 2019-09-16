using System;

namespace autoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine("The name in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " p);
        }
    }
}
