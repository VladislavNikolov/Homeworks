using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string[] allNums = Console.ReadLine().Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 1; i <= allNums.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddProduct *= int.Parse(allNums[i - 1]);
                }
                else
                {
                    evenProduct *= int.Parse(allNums[i - 1]);
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddProduct);
                Console.WriteLine("even_product = {0}", evenProduct);
            }
        }
    }
}
