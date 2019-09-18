using System;

namespace expressionBodied
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p);
            Console.WriteLine(p.AllCaps());
        }
    }
}
