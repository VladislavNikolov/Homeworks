using System;

class TargetPractice
{
    static void Main()
    {
        string[] firstline = Console.ReadLine().Split(' ');
        int rows = int.Parse(firstline[0]);
        int cols = int.Parse(firstline[1]);
        string snake = Console.ReadLine();
        char[,] matrix = FillTheMatrix(rows, cols, snake);
        string[] thirdLine = Console.ReadLine().Split(' ');
        int inpactRow = int.Parse(thirdLine[0]);
        int inpactCol = int.Parse(thirdLine[1]);
        double radius = double.Parse(thirdLine[2]);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (isPointInside(inpactRow, inpactCol, i, j, radius))
                {
                    matrix[i, j] = ' ';
                }
            }
        }

        matrix = CollapseThematrix(matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }

    }


    static char[,] FillTheMatrix(int rows, int cols, string snake)
    {
        char[,] patternB = new char[rows, cols];
        int counter = 1;
        int row = rows - 1;
        int col = cols - 1;
        bool reverse = true;
        int letter = 0;
        while (counter <= rows * cols)
        {
            if (reverse)
            {
                while (col >= 0)
                {
                    if (letter == snake.Length)
                    {
                        letter = 0;
                    }
                    patternB[row, col] = snake[letter];
                    col--;
                    counter++;
                    letter++;
                }
                col++;
                row--;
                reverse = false;
            }
            else
            {
                while (col < cols)
                {
                    if (letter == snake.Length)
                    {
                        letter = 0;
                    }
                    patternB[row, col] = snake[letter];
                    col++;
                    counter++;
                    letter++;
                }
                col--;
                row--;
                reverse = true;
            }
        }
        return patternB;
    }

    static bool isPointInside(int centerX, int centerY, int x1, int y1, double radius)
    {
        double radiusPow2 = radius * radius;

        double distancePow2 = Math.Pow((x1 - centerX), 2) + Math.Pow((y1 - centerY), 2);

        if (distancePow2 < radiusPow2)
        {
            return true;
        }
        else if (distancePow2 == radiusPow2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static char[,] CollapseThematrix(char[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1; row > -1; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == ' ')
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
        return matrix;
    }
}