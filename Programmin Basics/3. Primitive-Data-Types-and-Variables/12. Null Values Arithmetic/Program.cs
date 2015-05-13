using System;

/*
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.
 */

namespace Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("Result: {0}, {1}", a, b);

            a = a + 10;
            b = b + null;

            Console.WriteLine("Result 2: {0}, {1}", a, b);
        }
    }
}
