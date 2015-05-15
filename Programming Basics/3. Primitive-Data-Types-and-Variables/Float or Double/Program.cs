using System;

/*
 * Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

namespace Float_or_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 34.567839023;
            float num2 = 12.345f;
            double num3 = 8923.1234857;
            float num4 = 3456.091f;

            Console.WriteLine("{0}, {1}, {2}, {3}", num1, num2, num3, num4);
        }
    }
}
