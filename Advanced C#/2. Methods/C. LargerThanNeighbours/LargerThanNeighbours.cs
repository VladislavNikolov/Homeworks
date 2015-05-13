using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] allNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < allNums.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(allNums, i));
        }
    }

    static bool IsLargerThanNeighbours(int[] numbers, int position)
    {
        bool isLarger = true;
        if (position == 0)
        {
            isLarger = numbers[position] > numbers[position + 1];
        }
        else if (position == numbers.Length - 1)
        {
            isLarger = numbers[position] > numbers[position - 1];
        }
        else
        {
            isLarger = numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1];
        }
        return isLarger;
    }
}