using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNK
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long factorialN = 1;
            long factorialK = 1;
            int counterN = 1;
            int counterK = 1;

            while (counterN <= n || counterK <= k)
            {
                if (counterN <= n)
                {
                    factorialN *= counterN;
                }
                if (counterK <= k)
                {
                    factorialK *= counterK;
                }
                counterN++;
                counterK++;
            }
            Console.WriteLine(factorialN /factorialK);
        }
    }
}
