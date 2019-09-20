using System;

namespace nullCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            Console.WriteLine(s?.Length);
        }
    }
}
