using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggestNum = a;
            double secondBiggestNum = b;
            double smallestNum = c;

            if (a > b && a > c)
            {
                biggestNum = a;
                if (b > c)
                {
                    secondBiggestNum = b;
                    smallestNum = c;
                }
                else
                {
                    secondBiggestNum = c;
                    smallestNum = b;
                }
            }
            else if (b > a && b > c)
            {
                biggestNum = b;
                if (a > c)
                {
                    secondBiggestNum = a;
                    smallestNum = c;
                }
                else
                {
                    secondBiggestNum = c;
                    smallestNum = a;
                }
            }
            else if (c > a && c > b)
            {
                biggestNum = c;
                if (a > b)
                {
                    secondBiggestNum = a;
                    smallestNum = b;
                }
                else
                {
                    secondBiggestNum = b;
                    smallestNum = a;
                }
            }
            Console.WriteLine("{0} {1} {2}", biggestNum, secondBiggestNum, smallestNum);
        }
    }
}
