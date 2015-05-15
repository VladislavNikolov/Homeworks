using System;

/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 */

namespace Isosceles_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char copy = '\u00A9';

            Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copy);
        }
    }
}
