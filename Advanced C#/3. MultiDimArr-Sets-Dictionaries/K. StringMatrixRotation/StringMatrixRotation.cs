using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class StringMatrixRotation
{
    static void Main()
    {
        //Input
        string command = Console.ReadLine();
        Regex regex = new Regex(@"\d+");
        int degrees = int.Parse(regex.Match(command).ToString()) % 360;

        List<string> matrix = new List<string>();
        string matrixLine = Console.ReadLine();
        while (matrixLine != "END")
        {
            matrix.Add(matrixLine);

            matrixLine = Console.ReadLine();
        }

        //Get lenght
        int maxLength = 0;
        for (int i = 0; i < matrix.Count; i++)
        {
            if (matrix[i].Length > maxLength)
            {
                maxLength = matrix[i].Length;
            }
        }

        //Fill
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < matrix.Count; i++)
        {
            sb.Append(matrix[i]);
            while (sb.Length < maxLength)
            {
                sb.Append(" ");
            }
            matrix[i] = sb.ToString();
            sb.Clear();
        }

        //Rotate
        switch (degrees)
        {
            case 0:
                break;
            case 90:
                matrix = Rotate90Degrees(matrix, maxLength);
                break;
            case 180:
                matrix = Rotate180Degrees(matrix, maxLength);
                break;
            case 270:
                matrix = Rotate270Degrees(matrix, maxLength);
                break;
        }

        //Print
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(matrix[row][col]);
            }
            Console.WriteLine();
        }
    }

    static List<string> Rotate90Degrees(List<string> matrix, int length)
    {
        List<string> newMatrix = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int col = 0; col < length; col++)
        {
            for (int row = matrix.Count - 1; row > -1; row--)
            {
                sb.Append(matrix[row][col]);
            }
            newMatrix.Add(sb.ToString());
            sb.Clear();
        }
        return newMatrix;
    }

    static List<string> Rotate180Degrees(List<string> matrix, int length)
    {
        List<string> newMatrix = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int row = matrix.Count - 1; row > -1; row--)
        {
            for (int col = length - 1; col > -1; col--)
            {
                sb.Append(matrix[row][col]);
            }
            newMatrix.Add(sb.ToString());
            sb.Clear();
        }
        return newMatrix;
    }

    static List<string> Rotate270Degrees(List<string> matrix, int length)
    {
        List<string> newMatrix = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int col = length - 1; col > -1; col--)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                sb.Append(matrix[row][col]);
            }
            newMatrix.Add(sb.ToString());
            sb.Clear();
        }
        return newMatrix;
    }
}