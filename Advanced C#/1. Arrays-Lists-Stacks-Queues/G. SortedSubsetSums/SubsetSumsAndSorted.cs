using System;
using System.Linq;

//Best solution borrowed from Innos
//http://tinyurl.com/pyhjtvk

class SubsetSumsAndSorted
{
    static void Main()
    {
        bool solutionFound = false;
        int targetSum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        var subsets = (from m in Enumerable.Range(1, (1 << numbers.Length) - 1)
                       select
                             (from i in Enumerable.Range(0, numbers.Length)
                              where (m & (1 << i)) != 0
                              select numbers[i])
                             .ToList())
                             .Where(x => x.Sum() == targetSum)
                             .OrderBy(l => l.Count)
                             .ThenBy(l => l.First())
                             .Select(l => l.OrderBy(z => z));
        foreach (var subset in subsets)
        {
            Console.WriteLine("{0} = {1}", String.Join(" + ", subset), targetSum);
            solutionFound = true;
        }
        if (solutionFound == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}