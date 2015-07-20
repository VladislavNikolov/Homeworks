using System;
using System.Collections.Generic;

internal class ArrayMatcher
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split('\\');
        char[] leftArray = userInput[0].ToCharArray();
        char[] rightArray = userInput[1].ToCharArray();
        string command = userInput[2];
        List<char> outputArray = new List<char>();

        if (command == "join")
        {
            for (int i = 0; i < leftArray.Length; i++)
            {
                for (int j = 0; j < rightArray.Length; j++)
                {
                    if (leftArray[i] == rightArray[j])
                    {
                        outputArray.Add(leftArray[i]);
                    }
                }
            }
        }
        else if (command == "right exclude")
        {
            for (int i = 0; i < leftArray.Length; i++)
            {
                bool areArraysMatched = false;

                for (int j = 0; j < rightArray.Length; j++)
                {
                    if (leftArray[i] == rightArray[j])
                    {
                        areArraysMatched = true;
                        break;
                    }
                }

                if (!areArraysMatched)
                {
                    outputArray.Add(leftArray[i]);
                }
            }
        }
        else if (command == "left exclude")
        {
            for (int i = 0; i < rightArray.Length; i++)
            {
                bool areArraysMatched = false;

                for (int j = 0; j < leftArray.Length; j++)
                {
                    if (rightArray[i] == leftArray[j])
                    {
                        areArraysMatched = true;
                        break;
                    }
                }

                if (!areArraysMatched)
                {
                    outputArray.Add(rightArray[i]);
                }
            }
        }

        outputArray.Sort();

        Console.WriteLine(string.Join(string.Empty, outputArray));
    }
}