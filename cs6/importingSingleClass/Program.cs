using static System.Console;

namespace expressionBodied
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");

            /*
             * By importing a single class it allows you to use static methods
             * without constantly repeating the class. This makes it so you can
             * type `WriteLine()` instead of `Console.WriteLine()`. This is useful
             * when importing a class that has many static methods, such as 
             * the string class or the System.Math class.
             */
            WriteLine(p);

            Console.WriteLine(p.AllCaps());
        }
    }
}
