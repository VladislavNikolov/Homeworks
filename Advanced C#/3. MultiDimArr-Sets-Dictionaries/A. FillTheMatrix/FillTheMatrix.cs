using System;

internal class FillTheMatrix
{
    private static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        //Pattern A
        int[,] patternA = new int[size,size];
        int counter = 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                patternA[j, i] = counter;
                counter++;
            }
        }

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(patternA[j,i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Pattern B
        int[,] patternB = new int[size, size];
        counter = 1;
        int row = 0;
        int col = 0;
        bool reverse = false;
        while (counter <= size * size)
        {
            if (reverse)
            {
                while (row >= 0)
                {
                    patternB[row, col] = counter;
                    row--;
                    counter++;
                }
                col++;
                row++;
                reverse = false;
            }
            else
            {
                while (row < size)
                {
                    patternB[row, col] = counter;
                    row++;
                    counter++;
                }
                col++;
                row--;
                reverse = true;
            }          
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(patternB[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}