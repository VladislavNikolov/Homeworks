using System;
using System.Diagnostics;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (var reader = new StreamReader("Homework.txt"))
        {
            //Print all lines
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine();
        using (var reader = new StreamReader("Homework.txt"))
        {
            //Print odd lines
            string line;
            int counter = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
        }
    }
}