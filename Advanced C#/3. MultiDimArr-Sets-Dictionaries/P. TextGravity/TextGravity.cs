using System;
using System.Collections.Generic;

class TextGravity
{
    static void Main()
    {
        int matrixCols = int.Parse(Console.ReadLine());
        char[] text = Console.ReadLine().ToCharArray();

        //Fill the matrix
        int matrixRows = 0;
        int matrixSize = 0;
        if (matrixCols == 1)
        {
            matrixRows = text.Length;
        }
        else if (text.Length % matrixCols == 0)
        {
            matrixRows = text.Length/matrixCols;
        }
        else
        {
            matrixSize = text.Length + (matrixCols - text.Length % matrixCols);
            matrixRows = matrixSize / matrixCols;
        }        
        char[,] matrix = new char[matrixRows,matrixCols];
        int counter = 0;
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                if (counter < text.Length)
                {
                    matrix[i,j] = text[counter];
                    counter++;
                }
                else
                {
                    matrix[i,j] = ' ';
                }
            }
        }

        //Colapse the matrix
        for (int row = matrixRows - 1; row > -1; row--)
        {
            for (int col = 0; col < matrixCols; col++)
            {
                if (matrix[row,col] == ' ')
                {
                    int nextRow = row - 1;
                    while (nextRow > -1)
                    {
                        if (matrix[nextRow, col] != ' ')
                        {
                            char temp = matrix[row, col];
                            matrix[row, col] = matrix[nextRow, col];
                            matrix[nextRow, col] = temp;
                            break;
                        }
                        nextRow--;
                    }
                }
            }
        }

        //Print the matrix
        Console.Write("<table>");
        for (int i = 0; i < matrixRows; i++)
        {
            Console.Write("<tr>");
            for (int j = 0; j < matrixCols; j++)
            {
                Console.Write("<td>{0}</td>", matrix[i, j]);
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
    }
}