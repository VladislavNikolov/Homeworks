using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int currentIndex = 0;
        List<int> longestSequence = new List<int>();


        while (currentIndex < numbers.Length)
        {
            List<int> currentSequence = new List<int>();
            Console.Write(numbers[currentIndex] + " ");
            currentSequence.Add(numbers[currentIndex]);
            currentIndex++;
            if (currentIndex == numbers.Length)
            {
                break;
            }
            while (numbers[currentIndex] > numbers[currentIndex - 1])
            {
                Console.Write(numbers[currentIndex] + " ");
                currentSequence.Add(numbers[currentIndex]);
                currentIndex++;
                if (currentIndex == numbers.Length)
                {
                    break;
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = currentSequence;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
    }
}