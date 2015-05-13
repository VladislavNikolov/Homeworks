using System;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows,cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');
            if (command[0] == "END")
            {
                break;
            }
            else if (command[0] == "swap" && command.Length == 5)
            {
                if (int.Parse(command[1]) < rows && int.Parse(command[1]) >= 0 &&
                    int.Parse(command[2]) < cols && int.Parse(command[2]) >= 0 &&
                    int.Parse(command[3]) < rows && int.Parse(command[3]) >= 0 &&
                    int.Parse(command[4]) < cols && int.Parse(command[4]) >= 0)
                {
                    string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];
                    matrix[int.Parse(command[1]), int.Parse(command[2])] =
                        matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine();
            }
        }
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}