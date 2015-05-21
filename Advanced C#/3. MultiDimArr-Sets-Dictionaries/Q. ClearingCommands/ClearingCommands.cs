using System;
using System.Collections.Generic;
using System.Security;

class ClearingCommands
{
    static void Main()
    {
        //Fill the matrix
        List<char[]> matrix = new List<char[]>();
        string inputLine = Console.ReadLine();
        while (inputLine != "END")
        {
            matrix.Add(inputLine.ToCharArray());
            inputLine = Console.ReadLine();
        }

        //Clean the matrix
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {   
                if (matrix[row][col] == '>')
                {
                    int nextRow = row;
                    int nextCol = col + 1;
                    while (nextCol < matrix[row].Length && matrix[nextRow][nextCol] != '>' && matrix[nextRow][nextCol] != '<' &&
                        matrix[nextRow][nextCol] != 'v' && matrix[nextRow][nextCol] != '^')
                    {
                        matrix[nextRow][nextCol] = ' ';
                        nextCol++;
                    }
                    col = nextCol - 1;
                }
                else if (matrix[row][col] == '<')
                {
                    int nextRow = row;
                    int nextCol = col -1;
                    while (nextCol > -1 && matrix[nextRow][nextCol] != '>' && matrix[nextRow][nextCol] != '<' &&
                        matrix[nextRow][nextCol] != 'v' && matrix[nextRow][nextCol] != '^')
                    {
                        matrix[nextRow][nextCol] = ' ';
                        nextCol--;
                    }
                }
                else if (matrix[row][col] == 'v')
                {
                    int nextRow = row + 1;
                    int nextCol = col;
                    while (nextRow < matrix.Count && matrix[nextRow][nextCol] != '>' && matrix[nextRow][nextCol] != '<' &&
                        matrix[nextRow][nextCol] != 'v' && matrix[nextRow][nextCol] != '^')
                    {
                        matrix[nextRow][nextCol] = ' ';
                        nextRow++;
                    }
                }
                else if (matrix[row][col] == '^')
                {
                    int nextRow = row - 1;
                    int nextCol = col;
                    while (nextRow > -1 && matrix[nextRow][nextCol] != '>' && matrix[nextRow][nextCol] != '<' &&
                        matrix[nextRow][nextCol] != 'v' && matrix[nextRow][nextCol] != '^')
                    {
                        matrix[nextRow][nextCol] = ' ';
                        nextRow--;
                    }
                }
            }
        }

        //Print the matrix
        for (int row = 0; row < matrix.Count; row++)
        {
            Console.Write("<p>");
            for (int col = 0; col < matrix[row].Length; col++)
            {
                string result = SecurityElement.Escape(matrix[row][col].ToString());
                Console.Write(result);
 
            }
            Console.Write("</p>");
            Console.WriteLine();
        }
    }
}