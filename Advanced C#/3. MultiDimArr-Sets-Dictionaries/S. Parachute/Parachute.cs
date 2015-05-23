using System;
using System.Collections.Generic;

class Parachute
{
    static void Main()
    {
        //Fill the matrix
        string line = Console.ReadLine();
        List<char[]> matrix = new List<char[]>();
        int counter = 0;
        while (line != "END")
        {
            matrix.Add(new char[line.Length]);
            for (int i = 0; i < line.Length; i++)
            {
                matrix[counter][i] = line[i];
            }
            counter++;

            line = Console.ReadLine();
        }

        //Get the jumper's initial position
        int jumperRow = 0;
        int jumperCol = 0;
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 'o')
                {
                    jumperRow = i;
                    jumperCol = j;
                    break;
                }
            }   
        }

        //Determine the jumper's landing position
        for (int i = jumperRow; i < matrix.Count - 1; i++)
        {
            jumperRow++;
            int wind = WindDirection(matrix[jumperRow]);
            jumperCol += wind;
            if (matrix[jumperRow][jumperCol] == '_')
            {
                Console.WriteLine("Landed on the ground like a boss!");
                Console.WriteLine("{0} {1}", jumperRow, jumperCol);
                break;
            }
            else if (matrix[jumperRow][jumperCol] == '~')
            {
                Console.WriteLine("Drowned in the water like a cat!");
                Console.WriteLine("{0} {1}", jumperRow, jumperCol);
                break;
            }
            else if (matrix[jumperRow][jumperCol] == '/' || matrix[jumperRow][jumperCol] == '\\' ||
                matrix[jumperRow][jumperCol] == '|')
            {
                Console.WriteLine("Got smacked on the rock like a dog!");
                Console.WriteLine("{0} {1}", jumperRow, jumperCol);
                break;
            }
        }
    }

    private static int WindDirection(char[] arr)
    {
        int leftWind = 0;
        int rightWind = 0;
        foreach (char ch in arr)
        {
            if (ch == '>')
            {
                rightWind++;
            }
            else if (ch == '<')
            {
                leftWind++;
            }
        }
        int wind = rightWind - leftWind;
        return wind;
    }
}