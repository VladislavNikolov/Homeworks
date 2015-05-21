using System;
using System.Text;

class LittleJohn
{
    static void Main()
    {
        int smallArrows = 0;
        int mediumArrows = 0;
        int largeArrows = 0;
        for (int i = 0; i < 4; i++)
        {
            string hay = Console.ReadLine();
            for (int j = 0; j < hay.Length - 6; j++)
            {
                if (hay.IndexOf(">>>----->>", j) != -1)
                {
                    largeArrows++;
                    j = hay.IndexOf(">>>----->>", j) + 9;
                }
                else if (hay.IndexOf(">>----->", j) != -1)
                {
                    mediumArrows++;
                    j = hay.IndexOf(">>----->", j) + 7;
                }
                else if (hay.IndexOf(">----->", j) != -1)
                {
                    smallArrows++;
                    j = hay.IndexOf(">----->", j) + 6;
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        sb.Append(smallArrows);
        sb.Append(mediumArrows);
        sb.Append(largeArrows);
        string binary = Convert.ToString(int.Parse(sb.ToString()), 2);
        string binaryAndReverse = binary + GetReversedString(binary);
        string message = Convert.ToInt32(binaryAndReverse, 2).ToString();
        Console.WriteLine(message);
    }

    static string GetReversedString(string line)
    {
        char[] reversedChars = line.ToCharArray();
        Array.Reverse(reversedChars);
        string reversed = new string(reversedChars);

        return reversed;
    }
}