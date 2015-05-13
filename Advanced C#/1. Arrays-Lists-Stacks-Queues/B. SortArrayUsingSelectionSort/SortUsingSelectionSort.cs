using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortUsingSelectionSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int minimum = 0;
        int minPos = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            minimum = numbers[i];
            minPos = i;
            for (int j = 0; j < numbers.Length - (i + 1) ; j++)
            {
                if (numbers[i + j + 1] < minimum)
                {
                    minimum = numbers[i + j + 1];
                    minPos = i + j + 1;
                }
            }
            int temp = numbers[i];
            numbers[i] = numbers[minPos];
            numbers[minPos] = temp;
        }

        foreach (var number in numbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}