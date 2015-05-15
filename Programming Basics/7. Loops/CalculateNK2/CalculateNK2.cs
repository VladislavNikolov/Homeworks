using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateNK2
{
    class CalculateNK2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nMinusK = n - k;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNMinusK = 1;
            int counterN = 1;
            int counterK = 1;
            int counterNminusK = 1;

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
                if (counterNminusK <= nMinusK)
                {
                    factorialNMinusK *= counterNminusK;
                }
                counterN++;
                counterK++;
                counterNminusK++;
            }
            Console.WriteLine(factorialN / (factorialK * factorialNMinusK));

        }
    }
}
