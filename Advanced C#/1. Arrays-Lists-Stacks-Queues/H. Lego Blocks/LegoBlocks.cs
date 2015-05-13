using System;
using System.Linq;

internal class LegoBlocks
{
    private static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] leftBlock = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            string dirtyString = Console.ReadLine();
            string cleanedString = System.Text.RegularExpressions.Regex.Replace(dirtyString, @"\s+", " ");
            leftBlock[i] = cleanedString.Trim().Split(' ').Select(int.Parse).ToArray();
        }

        int[][] rightBlock = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            string dirtyString = Console.ReadLine();
            string cleanedString = System.Text.RegularExpressions.Regex.Replace(dirtyString, @"\s+", " ");
            rightBlock[i] = cleanedString.Trim().Split(' ').Select(int.Parse).ToArray();
        }

        bool match = true;
        int firstLength = leftBlock[0].Length + rightBlock[0].Length;

        for (int i = 1; i < rows; i++)
        {
            int nextLength = leftBlock[i].Length + rightBlock[i].Length;
            if (firstLength != nextLength)
            {
                match = false;
                break;
            }
        }

        if (match)
        {
            for (int i = 0; i < rows; i++)
            {
                Array.Reverse(rightBlock[i]);
                Console.WriteLine("[{0}, {1}]", string.Join(", ", leftBlock[i]), string.Join(", ", rightBlock[i]));
            }
        }
        else
        {
            int leftLength = 0;
            int rightLength = 0;
            for (int i = 0; i < rows; i++)
            {
                leftLength += leftBlock[i].Length;
                rightLength += rightBlock[i].Length;
            }
            Console.WriteLine("The total number of cells is: {0}", leftLength + rightLength);
        }
    }
}