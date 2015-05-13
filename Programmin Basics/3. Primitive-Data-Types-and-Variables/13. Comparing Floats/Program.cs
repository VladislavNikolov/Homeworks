using System;

/*
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
 */

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            double a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your second number:");
            double b = double.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine("Your numbers are the same!");
            }
            else
            {
                Console.WriteLine("Your numbers are not the same.");
            }
        }
    }
}
