using System;
using System.Collections.Generic;

class PlusRemove
{
    static void Main()
    {
        //Fill the matrix
        List<char[]> matrix = new List<char[]>();
        string matrixLine = Console.ReadLine();
        while (matrixLine != "END")
        {
            matrix.Add(matrixLine.ToCharArray());

            matrixLine = Console.ReadLine();
        }

        //Get locations
        HashSet<KeyValuePair<int, int>> coordinatesHS = new HashSet<KeyValuePair<int, int>>();
        for (int row = 0; row < matrix.Count - 2; row++)
        {
            for (int col = 0; col < matrix[row].Length - 2; col++)
            {
                if (IsPlus(matrix, row, col))
                {
                    coordinatesHS.Add(new KeyValuePair<int, int>(row, col));
                    coordinatesHS.Add(new KeyValuePair<int, int>(row, col + 2));
                    coordinatesHS.Add(new KeyValuePair<int, int>(row + 1, col + 1));
                    coordinatesHS.Add(new KeyValuePair<int, int>(row + 2, col));
                    coordinatesHS.Add(new KeyValuePair<int, int>(row + 2, col + 2));
                }
            }
        }

        //Print result
        KeyValuePair<int, int> currentPair = new KeyValuePair<int, int>();
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                currentPair = new KeyValuePair<int, int>(row, col);
                if (!coordinatesHS.Contains(currentPair))
                {
                    Console.Write(matrix[row][col]);
                }
            }
            Console.WriteLine();
        }
    }

    static bool IsPlus(List<char[]> matrix, int row, int col)
    {
        if (matrix[row + 1].Length >= col + 2 && matrix[row + 2].Length >= col + 3 &&
            matrix[row][col].ToString().ToUpper() == matrix[row][col + 2].ToString().ToUpper() &&
            matrix[row][col].ToString().ToUpper() == matrix[row + 1][col + 1].ToString().ToUpper() &&
            matrix[row][col].ToString().ToUpper() == matrix[row + 2][col].ToString().ToUpper() &&
            matrix[row][col].ToString().ToUpper() == matrix[row + 2][col + 2].ToString().ToUpper())
        {
            return true;
        }
        return false;
    }
}