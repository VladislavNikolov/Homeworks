using System;
using System.Linq;

class MaximalSum
{
    private static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int rows = int.Parse(firstLine[0]);
        int cols = int.Parse(firstLine[1]);
        int size = 3;

        //Fill the matrix
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < row.Length; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        //Find the best sum
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < rows - size + 1; row++)
        {
            for (int col = 0; col < cols - size + 1; col++)
            {
                int sum = GetSum(row, col, matrix, size);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Sum = {0}", bestSum);
        for (int row = bestRow; row < bestRow + size; row++)
        {
            for (int col = bestCol; col < bestCol + size; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }

    static int GetSum(int indexRow, int indexCol, int[,] matrix, int size)
    {
        int sum = 0;
        for (int row = indexRow; row < indexRow + size; row++)
        {
            for (int col = indexCol; col < indexCol + size; col++)
            {
                sum += matrix[row, col];
            }
        }
        return sum;
    }
}
