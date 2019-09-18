using System;

namespace backingFieldsAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Billy", "Doe");
            Console.WriteLine(p);
            Console.WriteLine(p.FirstName);
        }
    }
}
