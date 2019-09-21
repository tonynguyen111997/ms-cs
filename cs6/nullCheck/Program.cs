using System;

namespace nullCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The null conditional operator helps you write code that makes your core logic 
             * clear while seamlessly testing for null values.
             */
             
            /*
             * The ? returns null if its left operand is null. If the 
             * type of the right operand is a value type, the ? operator returns
             * a nullable type for that type. Can also use ?[] for array or indexer access.
             */
            string s = null;
            Console.WriteLine("s length: " + s?.Length);

            char? c = s?[0];
            Console.WriteLine("?[]: " + c.HasValue);

            // Multiple conditional operator
            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            Console.WriteLine("Multiple conditional operator " + hasMore.HasValue);

            // Provides a default value of false
            bool hasEvenMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? true;
            Console.WriteLine("Null Coalescing Operator " + hasEvenMore);

        }
    }
}
