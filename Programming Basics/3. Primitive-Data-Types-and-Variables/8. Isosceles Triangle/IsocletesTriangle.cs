using System;

/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 */

namespace Isosceles_Triangle
{
    internal class IsocletesTriangle
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int numberOfRows = int.Parse(Console.ReadLine());
            char copyright = '\u00A9';
            int leftSide = numberOfRows;
            int rightSide = numberOfRows;
            for (int i = 1; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows * 2; j++)
                {
                    if (j == leftSide || j == rightSide)
                    {
                        Console.Write(copyright);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
          
                leftSide -= 1;
                rightSide += 1;
                Console.WriteLine();
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write(" {0}", copyright);
            }

            Console.WriteLine();
        }
    }
}