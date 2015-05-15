using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            double repeat = int.Parse(Console.ReadLine());
            int lowest = Int32.MaxValue;
            int highest = Int32.MinValue;
            int sum = 0;
            double average = 0;

            for (int i = 0; i < repeat; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < lowest)
                {
                    lowest = number;
                }
                if (number > highest)
                {
                    highest = number;
                }
                sum += number;
            }
            average = sum / repeat;
            Console.WriteLine("min = {0}", lowest);
            Console.WriteLine("max = {0}", highest);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", average);
        }
    }
}
