using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "<name>", "Ana", "Felipe"};
            names.Add("Test");
            names.Remove("Ana");
            names.Add("Test2");
            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"List: {names}");
            Console.WriteLine($"List length {names.Count}");
            List<int> numberList = new List<int> {};
            numberList.Add(12);
            numberList.Add(10);
            numberList.ForEach(num => {
                Console.WriteLine(num);
            });
        }
    }
}
