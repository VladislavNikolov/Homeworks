using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    private static void Main()
    {
        int[] allNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(GetIndexOfFirstLarger(allNums));

    }

    static int GetIndexOfFirstLarger(int[] numbers)
    {
        int indexOfFirst = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))
            {
                indexOfFirst = i;
                break;
            }
        }
        return indexOfFirst;
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