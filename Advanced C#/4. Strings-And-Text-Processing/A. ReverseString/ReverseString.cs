using System;

class ReverseString
{
    static void Main()
    {
        string stringToReverse = Console.ReadLine();

        string reversedString = GetReversedString(stringToReverse);
        Console.WriteLine(reversedString);
    }

    static string GetReversedString(string line)
    {
        char[] reversedChars = line.ToCharArray();
        Array.Reverse(reversedChars);
        string reversed = new string(reversedChars);

        return reversed;
    }
}