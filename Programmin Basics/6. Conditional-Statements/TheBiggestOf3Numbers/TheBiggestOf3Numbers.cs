using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggestNum = a;

            if (a < b && b > c)
            {
                biggestNum = b;
            }
            else if (a < c && c > b)
            {
                biggestNum = c;
            }
            else if (b < a && a > c)
            {
                 biggestNum = a;
            }
            Console.WriteLine(biggestNum);
        }
    }
}
