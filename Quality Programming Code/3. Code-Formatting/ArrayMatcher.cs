using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        char[] array1 = input[0].ToCharArray();
        char[] array2 = input[1].ToCharArray();
        string cmd = input[2];
        List<char> array3 = new List<char>();

        if (cmd == "join")
        {

            for (int i = 0; i < array1.Length; i++)
            {

                for (int j = 0; j < array2.Length; j++)
                {

                    if (array1[i] == array2[j])
                    {
                        array3.Add(array1[i]);
                    }
                }
            }
        }
        else if (cmd == "right exclude")
        {

            for (int i = 0; i < array1.Length; i++)
            {

                int counter = 0;

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    array3.Add(array1[i]);
                }
            }
        }
        else if (cmd == "left exclude")
        {

            for (int i = 0; i < array2.Length; i++)
            {

                int counter = 0;

                for (int j = 0; j < array1.Length; j++)
                {

                    if (array2[i] == array1[j])
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    array3.Add(array2[i]);
                }
            }
        }
        array3.Sort();
        foreach (char item in array3)
        {
            Console.Write(item);
        }
        Console.WriteLine();

    }
}