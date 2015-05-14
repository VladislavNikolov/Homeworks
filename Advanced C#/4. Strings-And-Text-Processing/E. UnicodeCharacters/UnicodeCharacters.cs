using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        Console.WriteLine(GetUnicode(inputLine));//Print using the first method
        for (int i = 0; i < inputLine.Length; i++)
        {
            Console.Write(GetUnicode(inputLine[i]));//Print using the second method
        }
        Console.WriteLine();
    }

    static string GetUnicode(string s)//Returns the entire string to print
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }

    static string GetUnicode(char c)//Returns each character to print
    {
        string unicode = ("\\u" + ((int)c).ToString("X4"));

        return unicode;
    }
}