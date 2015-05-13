using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double biggestNum = a;

            if (a > b && a > c && a > d && a > e)
            {
                biggestNum = a;
            }
            else if (b > a && b > c && b > d && b > e)
            {
                biggestNum = b;
            }
            else if (c > a && c > b && c > d && c > e)
            {
                biggestNum = c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                biggestNum = d;
            }
            else if (e > a && e > b && e > c && e > d)
            {
                biggestNum = e;
            }
            Console.WriteLine(biggestNum);
        }
    }
}
