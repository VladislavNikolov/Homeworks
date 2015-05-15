using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate1PlusEtc
{
    class Calculate1PlusEtc
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1M;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (decimal)(factorial / Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
