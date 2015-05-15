using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random ran = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(ran.Next(min, max) + " ");
            }
            Console.WriteLine();
        }
    }
}
