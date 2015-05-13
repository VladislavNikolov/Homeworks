using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfNumbers
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}