using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nTimes2 = n * 2;
            int nPlus1 = n + 1;
            BigInteger factorialN = 1;
            BigInteger factorialNTimes2 = 1;
            BigInteger factorialNPlus1 = 1;
            int counterN = 1;
            int counterNTimes2 = 1;
            int counterNPlus1 = 1;

            while (counterNTimes2 <= nTimes2)
            {
                if (counterN <= n)
                {
                    factorialN *= counterN;
                }
                if (counterNTimes2 <= nTimes2)
                {
                    factorialNTimes2 *= counterNTimes2;
                }
                if (counterNPlus1 <= nPlus1)
                {
                    factorialNPlus1 *= counterNPlus1;
                }
                counterN++;
                counterNTimes2++;
                counterNPlus1++;
            }
            Console.WriteLine(factorialNTimes2 / (factorialNPlus1 * factorialN));
        }
    }
}
